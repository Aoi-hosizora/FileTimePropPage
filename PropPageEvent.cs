using System;
using System.Drawing;
using System.Linq;
using SharpShell.SharpPropertySheet;
using Utils;
using Module;
using System.Windows.Forms;

namespace PropPage_UI {
    public partial class PropPage : SharpPropertyPage {
        
        public PropPage() {
            InitializeComponent();
            PageTitle = "ファイル日時";
        }

        private string filePath { get; set; }
        private FileTimes fileDateTimes { get; set; }

        #region Override

        protected override void OnPropertyPageInitialised(SharpPropertySheet parent) =>
            initData(parent);

        protected override void OnPropertySheetApply() =>
            ApplyOK();

        protected override void OnPropertySheetOK() =>
            ApplyOK();

        #endregion // Override

        #region MainFunc

        private void initData(SharpPropertySheet parent) {
            filePath = parent.SelectedItemPaths.First();
            fileDateTimes = Util.LoadFileTimes(filePath);

            this.datePicker_Create.Value = fileDateTimes.CreateTime;
            this.datePicker_Update.Value = fileDateTimes.UpdateTime;
            this.datePicker_Access.Value = fileDateTimes.AccessTime;
            
            this.timePicker_Create.Value = fileDateTimes.CreateTime;
            this.timePicker_Update.Value = fileDateTimes.UpdateTime;
            this.timePicker_Access.Value = fileDateTimes.AccessTime;
        }

        private void ApplyOK() {
            DateTime createDate, createTime, updateDate, updateTime, accessDate, accessTime;
            createDate = this.datePicker_Create.Value;
            createTime = this.timePicker_Create.Value;
            updateDate = this.datePicker_Update.Value;
            updateTime = this.timePicker_Update.Value;
            accessDate = this.datePicker_Access.Value;
            accessTime = this.timePicker_Access.Value;

            DateTime ct = new DateTime(createDate.Year, createDate.Month, createDate.Day, createTime.Hour, createTime.Minute, createTime.Second);
            DateTime ut = new DateTime(updateDate.Year, updateDate.Month, updateDate.Day, updateTime.Hour, updateTime.Minute, updateTime.Second);
            DateTime at = new DateTime(accessDate.Year, accessDate.Month, accessDate.Day, accessTime.Hour, accessTime.Minute, accessTime.Second);

            FileTimes fileTimes = new FileTimes(ct: ct, ut: ut, at: at);

            if (!Util.SaveFileTimes(filePath, fileTimes)) { // if error
                if (Util.isAdmin()) // error when has authority 
                    showErrorAlert();
                else { // no authority
                    Util.getAdmin(); // TODO
                    if (!Util.SaveFileTimes(filePath, fileTimes)) // error when has authority 
                        showErrorAlert();
                }
            }
        }

        private void showErrorAlert() =>
            MessageBox.Show("ファイル日時の変更は失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

        #endregion // MainFunc

        #region UI_Buttons

        private void PropPage_Load(object sender, EventArgs e) {
            this.BackColor = Color.White;
        }

        /// <summary>
        /// 作成日時 復元
        /// </summary>
        private void button_Create_Recover_Click(object sender, EventArgs e) {
            this.datePicker_Create.Value = fileDateTimes.CreateTime;
            this.timePicker_Create.Value = fileDateTimes.CreateTime;
        }

        /// <summary>
        /// 作成日時 今に
        /// </summary>
        private void button_Create_Now_Click(object sender, EventArgs e) {
            this.datePicker_Create.Value = DateTime.Now;
            this.timePicker_Create.Value = DateTime.Now;
        }

        /// <summary>
        /// 更新日時 復元
        /// </summary>
        private void button_Update_Recover_Click(object sender, EventArgs e) {
            this.datePicker_Update.Value = fileDateTimes.UpdateTime;
            this.timePicker_Update.Value = fileDateTimes.UpdateTime;
        }

        /// <summary>
        /// 更新日時 今に
        /// </summary>
        private void button_Update_Now_Click(object sender, EventArgs e) {
            this.datePicker_Update.Value = DateTime.Now;
            this.timePicker_Update.Value = DateTime.Now;
        }

        /// <summary>
        /// ｱｸｾｽ日時 復元
        /// </summary>
        private void button_Access_Recover_Click(object sender, EventArgs e) {
            this.datePicker_Access.Value = fileDateTimes.AccessTime;
            this.timePicker_Access.Value = fileDateTimes.AccessTime;
        }

        /// <summary>
        /// ｱｸｾｽ日時 今に
        /// </summary>
        private void button_Access_Now_Click(object sender, EventArgs e) {
            this.datePicker_Access.Value = DateTime.Now;
            this.timePicker_Access.Value = DateTime.Now;
        }

        #endregion // UI_Buttons
    }
}