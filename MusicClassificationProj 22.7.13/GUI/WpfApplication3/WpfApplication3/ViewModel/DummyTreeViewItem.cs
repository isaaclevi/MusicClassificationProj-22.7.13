using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicClassificationGui.ViewModel
{
    public class DummyTreeViewItem : BrowserTreeViewItem
    {
        public DummyTreeViewItem()
            : base()
        {
            base.Header = "Dummy";
            base.Tag = "Dummy";
        }

    }
}
