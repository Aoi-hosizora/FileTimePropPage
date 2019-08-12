using System;
using System.Drawing;
using System.Linq;
using SharpShell.SharpPropertySheet;
using Utils;
using Module;

namespace PropPage_UI {
    public partial class PropPage : SharpPropertyPage {
        public PropPage() {
            InitializeComponent();
            PageTitle = "ファイル日時";
        }

        private string filePath { get; set; }

        protected override void OnPropertyPageInitialised(SharpPropertySheet parent) {
            filePath = parent.SelectedItemPaths.First();
            FileTimes fileTimes = Util.LoadFileTimes(filePath);

            this.datePicker_Create.Value = fileTimes.CreateTime;
            this.datePicker_Update.Value = fileTimes.UpdateTime;
            this.datePicker_Access.Value = fileTimes.AccessTime;
            
            this.timePicker_Create.Value = fileTimes.CreateTime;
            this.timePicker_Update.Value = fileTimes.UpdateTime;
            this.timePicker_Access.Value = fileTimes.AccessTime;
        }

        protected override void OnPropertySheetApply() =>
            ApplyOK();

        protected override void OnPropertySheetOK() =>
            ApplyOK();

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
            Util.SaveFileTimes(filePath, fileTimes);
        }

        private void PropPage_Load(object sender, EventArgs e) {
            this.BackColor = Color.White;
        }
    }
}