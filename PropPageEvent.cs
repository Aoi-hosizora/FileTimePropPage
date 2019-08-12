using System.Linq;
using SharpShell.SharpPropertySheet;
using Utils;

namespace PropPage_UI {
    public partial class PropPage : SharpPropertyPage {
        public PropPage() {
            InitializeComponent();
            PageTitle = "ファイル日時";
        }

        private string filePath { get; set; }

        protected override void OnPropertyPageInitialised(SharpPropertySheet parent) {
            filePath = parent.SelectedItemPaths.First();
            Util.LoadFileTimes(filePath);
        }

        protected override void OnPropertySheetApply() =>
            Util.SaveFileTimes(filePath);

        protected override void OnPropertySheetOK() =>
            Util.SaveFileTimes(filePath);        
    }
}