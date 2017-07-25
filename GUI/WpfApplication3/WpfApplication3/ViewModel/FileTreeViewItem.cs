using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace MusicClassificationGui.ViewModel
{
    public class FileTreeViewItem: BrowserTreeViewItem
    {
        private System.IO.FileInfo file;

        public FileTreeViewItem(FileInfo file):base()
        {
            // TODO: Complete member initialization
            this.file = file;
            Header = file.Name;
            DataContext = file;
            Tag = file;
        }
    }
}
