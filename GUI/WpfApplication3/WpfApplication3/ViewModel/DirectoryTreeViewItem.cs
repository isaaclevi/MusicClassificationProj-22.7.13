using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicClassificationGui.ViewModel
{
    public class DirectoryTreeViewItem:BrowserTreeViewItem
    {

        public DirectoryTreeViewItem(DirectoryInfo directory):base()
        {
            Header = directory.Name;
            DataContext = directory;
            Tag = directory;
        }
    }
}
