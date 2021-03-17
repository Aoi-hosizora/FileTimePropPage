using SharpShell.SharpPropertySheet;
using System;
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
        private DateTime selectedFileCt;
        private DateTime selectedFileUt;
        private DateTime selectedFileAt;

        private void Initialize(SharpPropertySheet parent) {
            selectedFilepath = parent.SelectedItemPaths.First();

            var info = new FileInfo(selectedFilepath);
            selectedFileCt = info.CreationTime;
            selectedFileUt = info.LastWriteTime;
            selectedFileAt = info.LastAccessTime;

            DpCreate.Value = selectedFileCt;
            TpCreate.Value = selectedFileCt;
            DpUpdate.Value = selectedFileUt;
            TpUpdate.Value = selectedFileUt;
            DpAccess.Value = selectedFileAt;
            TpAccess.Value = selectedFileAt;
        }

        private void ApplyOrOK() {
            var ct = new DateTime(DpCreate.Value.Year, DpCreate.Value.Month, DpCreate.Value.Day, TpCreate.Value.Hour, TpCreate.Value.Minute, TpCreate.Value.Second);
            var ut = new DateTime(DpUpdate.Value.Year, DpUpdate.Value.Month, DpUpdate.Value.Day, TpUpdate.Value.Hour, TpUpdate.Value.Minute, TpUpdate.Value.Second);
            var at = new DateTime(DpAccess.Value.Year, DpAccess.Value.Month, DpAccess.Value.Day, TpAccess.Value.Hour, TpAccess.Value.Minute, TpAccess.Value.Second);

            try {
                var info = new FileInfo(selectedFilepath);
                info.CreationTime = ct;
                info.LastWriteTime = ut;
                info.LastAccessTime = at;
                selectedFileCt = ct;
                selectedFileUt = ut;
                selectedFileAt = at;
            } catch (Exception) {
                MessageBox.Show(new Form { TopMost = true }, "ファイル日時の変更は失敗しました。", "ファイル日時", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCreateRestore_Click(object sender, EventArgs e) {
            DpCreate.Value = selectedFileCt;
            TpCreate.Value = selectedFileCt;
        }

        private void BtnCreateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpCreate.Value = now;
            TpCreate.Value = now;
        }

        private void BtnUpdateRestore_Click(object sender, EventArgs e) {
            DpUpdate.Value = selectedFileUt;
            TpUpdate.Value = selectedFileUt;
        }

        private void BtnUpdateNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpUpdate.Value = now;
            TpUpdate.Value = now;
        }

        private void BtnAccessRestore_Click(object sender, EventArgs e) {
            DpAccess.Value = selectedFileAt;
            TpAccess.Value = selectedFileAt;
        }

        private void BtnAccessNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            DpAccess.Value = now;
            TpAccess.Value = now;
        }
    }
}
