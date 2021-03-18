using Microsoft.Win32;
using SharpShell.SharpPropertySheet;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileTimePropPage.Extension {

    public partial class PropertyPage : SharpPropertyPage {

        public PropertyPage() {
            InitializeComponent();
            PageTitle = "ファイル日時";
        }

        protected override void OnPropertyPageInitialised(SharpPropertySheet parent) {
            Initialize(parent);
        }

        protected override void OnPropertySheetApply() {
            ApplyOrOK();
        }

        protected override void OnPropertySheetOK() {
            ApplyOrOK();
        }

        private string selectedFilepath;

        /// <summary>
        /// Initialize data from property sheet.
        /// </summary>
        /// <param name="parent"></param>
        private void Initialize(SharpPropertySheet parent) {
            selectedFilepath = parent.SelectedItemPaths.First();
            var (ct, ut, at) = GetFileDatetimes(selectedFilepath);
            DpCreate.Value = ct;
            TpCreate.Value = ct;
            DpUpdate.Value = ut;
            TpUpdate.Value = ut;
            DpAccess.Value = at;
            TpAccess.Value = at;
        }

        /// <summary>
        /// Click Apply or OK button.
        /// </summary>
        private void ApplyOrOK() {
            // get datetimes and check
            var ct = new DateTime(DpCreate.Value.Year, DpCreate.Value.Month, DpCreate.Value.Day, TpCreate.Value.Hour, TpCreate.Value.Minute, TpCreate.Value.Second);
            var ut = new DateTime(DpUpdate.Value.Year, DpUpdate.Value.Month, DpUpdate.Value.Day, TpUpdate.Value.Hour, TpUpdate.Value.Minute, TpUpdate.Value.Second);
            var at = new DateTime(DpAccess.Value.Year, DpAccess.Value.Month, DpAccess.Value.Day, TpAccess.Value.Hour, TpAccess.Value.Minute, TpAccess.Value.Second);
            var (originCt, originUt, originAt) = GetFileDatetimes(selectedFilepath);
            if (originCt == ct && originUt == ut && originAt == at) {
                return;
            }

            // get implementation executable file
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AoiHosizora\FileTimePropPage");
            if (key == null) {
                MessageBox.Show(new Form { TopMost = true },
                    @"ファイル日時ページのレジストリ設定はまだ設置されていません。HKEY_CURRENT_USER\SOFTWARE\AoiHosizora\FileTimePropPage の Implementation キーを確認してください。",
                    "ファイル日時", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var executablePath = key.GetValue("Implementation") as string;
            executablePath = executablePath.Trim('"');
            if (string.IsNullOrWhiteSpace(executablePath) || !File.Exists(executablePath)) {
                MessageBox.Show(new Form { TopMost = true },
                    @"ファイル日時ページの実現アプリケーションは見つかりません。HKEY_CURRENT_USER\SOFTWARE\AoiHosizora\FileTimePropPage の Implementation キーを確認してください。",
                    "ファイル日時", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // call implementation
            var format = "yyyy-MM-ddTHH:mm:ss";
            var args = new string[] { selectedFilepath, ct.ToString(format), ut.ToString(format), at.ToString(format) };
            var process = new Process();
            var psi = new ProcessStartInfo(executablePath, string.Join(" ", args)) {
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.StartInfo = psi;
            process.Start();
            // process.WaitForExit();

            // TODO error
            // var (currCt, currUt, currAt) = GetFileDatetimes(selectedFilepath);
            // if (currCt != ct || currUt != ut || currAt != at) { }
        }

        /// <summary>
        /// Return 3 datetimes from given filepath.
        /// </summary>
        private Tuple<DateTime, DateTime, DateTime> GetFileDatetimes(string filepath) {
            var info = new FileInfo(filepath);
            var ct = new DateTime(info.CreationTime.Year, info.CreationTime.Month, info.CreationTime.Day,
                info.CreationTime.Hour, info.CreationTime.Minute, info.CreationTime.Second);
            var ut = new DateTime(info.LastWriteTime.Year, info.LastWriteTime.Month, info.LastWriteTime.Day,
                info.LastWriteTime.Hour, info.LastWriteTime.Minute, info.LastWriteTime.Second);
            var at = new DateTime(info.LastAccessTime.Year, info.LastAccessTime.Month, info.LastAccessTime.Day,
                info.LastAccessTime.Hour, info.LastAccessTime.Minute, info.LastAccessTime.Second);
            return new Tuple<DateTime, DateTime, DateTime>(ct, ut, at);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e) {
            SetPageDataChanged(true);
        }

        private void BtnCreateRestore_Click(object sender, EventArgs e) {
            var ct = GetFileDatetimes(selectedFilepath).Item1;
            DpCreate.Value = ct;
            TpCreate.Value = ct;
            SetPageDataChanged(true);
        }

        private void BtnCreateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpCreate.Value = now;
            TpCreate.Value = now;
            SetPageDataChanged(true);
        }

        private void BtnUpdateRestore_Click(object sender, EventArgs e) {
            var ut = GetFileDatetimes(selectedFilepath).Item2;
            DpUpdate.Value = ut;
            TpUpdate.Value = ut;
            SetPageDataChanged(true);
        }

        private void BtnUpdateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpUpdate.Value = now;
            TpUpdate.Value = now;
            SetPageDataChanged(true);
        }

        private void BtnAccessRestore_Click(object sender, EventArgs e) {
            var at = GetFileDatetimes(selectedFilepath).Item3;
            DpAccess.Value = at;
            TpAccess.Value = at;
            SetPageDataChanged(true);
        }

        private void BtnAccessNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpAccess.Value = now;
            TpAccess.Value = now;
            SetPageDataChanged(true);
        }
    }
}
