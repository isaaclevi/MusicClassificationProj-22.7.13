using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicClassificationGui.ViewModel
{
    public class DriveTreeViewItem:BrowserTreeViewItem
    {
        public DriveTreeViewItem(DriveInfo drive):base()
        {
            this.Drive = drive;
            Header = drive.Name;
            DataContext = drive;
            Tag = drive;
        }

        public System.IO.DriveInfo Drive { get; set; }
    }
}
