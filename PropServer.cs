using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.SharpPropertySheet;
using PropPage_UI;

[ComVisible(true)]
[COMServerAssociation(AssociationType.AllFiles)]
public class PropServer : SharpPropertySheet {
    protected override bool CanShowSheet() =>
        SelectedItemPaths.Count() == 1;
    
    protected override IEnumerable<SharpPropertyPage> CreatePages() =>
        new[] { new PropPage() };
}