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

        private void Initialize(SharpPropertySheet parent) {
            selectedFilepath = parent.SelectedItemPaths.First();

            var info = new FileInfo(selectedFilepath);
            DpCreate.Value = info.CreationTime;
            TpCreate.Value = info.CreationTime;
            DpUpdate.Value = info.LastWriteTime;
            TpUpdate.Value = info.LastWriteTime;
            DpAccess.Value = info.LastAccessTime;
            TpAccess.Value = info.LastAccessTime;
        }

        private void ApplyOrOK() {
            var ct = new DateTime(DpCreate.Value.Year, DpCreate.Value.Month, DpCreate.Value.Day,
                TpCreate.Value.Hour, TpCreate.Value.Minute, TpCreate.Value.Second);
            var ut = new DateTime(DpUpdate.Value.Year, DpUpdate.Value.Month, DpUpdate.Value.Day,
                TpUpdate.Value.Hour, TpUpdate.Value.Minute, TpUpdate.Value.Second);
            var at = new DateTime(DpAccess.Value.Year, DpAccess.Value.Month, DpAccess.Value.Day,
                TpAccess.Value.Hour, TpAccess.Value.Minute, TpAccess.Value.Second);

            // get implementation executable file
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AoiHosizora\FileTimePropPage");
            if (key == null) {
                MessageBox.Show(new Form { TopMost = true }, @"You have not set FileTimePropPage's registry setting, please check the Implementation key from HKEY_CURRENT_USER\SOFTWARE\AoiHosizora\FileTimePropPage.",
                   "Mp3CoverDroper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var executablePath = key.GetValue("Implementation") as string;
            executablePath = executablePath.Trim('"');
            if (string.IsNullOrWhiteSpace(executablePath) || !File.Exists(executablePath)) {
                MessageBox.Show(new Form { TopMost = true }, @"FileTimePropPage's implementation application file is not found, please check the Implementation key from HKEY_CURRENT_USER\SOFTWARE\AoiHosizora\FileTimePropPage.",
                   "Mp3CoverDroper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // call implementation
            var format = "yyyy-MM-ddTHH:mm:ss";
            var args = new string[] { selectedFilepath, ct.ToString(format), ut.ToString(format), at.ToString(format) };
            var process = new Process();
            var info = new ProcessStartInfo(executablePath, string.Join(" ", args)) {
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.StartInfo = info;
            process.Start();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e) {
            SetPageDataChanged(true);
        }

        private void BtnCreateRestore_Click(object sender, EventArgs e) {
            var info = new FileInfo(selectedFilepath);
            DpCreate.Value = info.CreationTime;
            TpCreate.Value = info.CreationTime;
            SetPageDataChanged(true);
        }

        private void BtnCreateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpCreate.Value = now;
            TpCreate.Value = now;
            SetPageDataChanged(true);
        }

        private void BtnUpdateRestore_Click(object sender, EventArgs e) {
            var info = new FileInfo(selectedFilepath);
            DpUpdate.Value = info.LastWriteTime;
            TpUpdate.Value = info.LastWriteTime;
            SetPageDataChanged(true);
        }

        private void BtnUpdateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpUpdate.Value = now;
            TpUpdate.Value = now;
            SetPageDataChanged(true);
        }

        private void BtnAccessRestore_Click(object sender, EventArgs e) {
            var info = new FileInfo(selectedFilepath);
            DpAccess.Value = info.LastAccessTime;
            TpAccess.Value = info.LastAccessTime;
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
