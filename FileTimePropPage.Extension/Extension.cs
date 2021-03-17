using SharpShell.Attributes;
using SharpShell.SharpPropertySheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FileTimePropPage.Extension {

    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class Extension : SharpPropertySheet {

        protected override bool CanShowSheet() {
            return SelectedItemPaths.Count() == 1;
        }

        protected override IEnumerable<SharpPropertyPage> CreatePages() {
            return new SharpPropertyPage[] { new PropertyPage() };
        }
    }
}
