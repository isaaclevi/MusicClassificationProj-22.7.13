using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MusicClassificationBL;

namespace MusicClassificationGui.ViewModel
{
    public class BrowserTreeViewItem : TreeViewItem
    {
        #region Members
        private ObservableCollection<SongProp> m_ocSongPropList = new ObservableCollection<SongProp>();
        public event Action<ObservableCollection<SongProp>> ItemSelected;
        private string m_strPicPath; 
        #endregion


        


        #region Ctor
        public BrowserTreeViewItem()
        {
            this.Expanded += new RoutedEventHandler(item_Expanded);
            this.Selected += item_Selected;
        } 
        #endregion

        #region Prop

        public ObservableCollection<SongProp> SongPropList
        {
            get { return m_ocSongPropList; }
            set { m_ocSongPropList = value; }
        }

        public string Pic
        {
            get { return m_strPicPath; }
            set { m_strPicPath = value; }
        }

        #endregion

        #region Private events
        private void item_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;
            if (this.HasDummy(item))
            {
                this.Cursor = Cursors.Wait;
                this.RemoveDummy(item);
                this.ExploreDirectories(item);
                this.ExploreFiles(item);
                this.Cursor = Cursors.Arrow;

            }
        }

        private void item_Selected(object sender, RoutedEventArgs e)
        {
            this.SongPropList.Clear();
            TreeViewItem item = sender as TreeViewItem;
            var directoryInfo = (DirectoryInfo)null;
            if (item.Tag is DriveInfo)
            {
                directoryInfo = ((DriveInfo)item.Tag).RootDirectory;
            }
            else if (item.Tag is DirectoryInfo)
            {
                directoryInfo = (DirectoryInfo)item.Tag;
            }
            else if (item.Tag is FileInfo)
            {
                directoryInfo = ((FileInfo)item.Tag).Directory;
            }
            if (object.ReferenceEquals(directoryInfo, null)) return;
            foreach (var file in directoryInfo.GetFiles())
            {
                var isHidden = (file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
                var isSystem = (file.Attributes & FileAttributes.System) == FileAttributes.System;

                String extention = file.Extension; //gets the file's extention
                var isMP3 = extention.ToLower().Equals(".mp3"); //checks if the file is MP3
                var isWAV = extention.ToLower().Equals(".wav"); //checks if the file is WAV
                if (!isHidden && !isSystem && (isMP3 || isWAV)) //if the file is not a hidden system file or an MP3, WAV
                {
                    //SongsList.Add(new SongClass(file.FullName));
                    this.SongPropList.Add(new SongProp(file.FullName));
                }
            }   
            if (this.ItemSelected!=null)
            {
                this.ItemSelected(this.m_ocSongPropList);
            }
        } 
        #endregion

        #region Private methods
        private void ExploreDirectories(TreeViewItem item)
        {
            var directoryInfo = (DirectoryInfo)null;
            if (item.Tag is DriveInfo)
            {
                directoryInfo = ((DriveInfo)item.Tag).RootDirectory;
            }
            else if (item.Tag is DirectoryInfo)
            {
                directoryInfo = (DirectoryInfo)item.Tag;
            }
            else if (item.Tag is FileInfo)
            {
                directoryInfo = ((FileInfo)item.Tag).Directory;
            }
            if (object.ReferenceEquals(directoryInfo, null)) return;
            foreach (var directory in directoryInfo.GetDirectories())
            {
                var isHidden = (directory.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
                var isSystem = (directory.Attributes & FileAttributes.System) == FileAttributes.System;
                if (!isHidden && !isSystem)
                {
                    BrowserTreeViewItem btvi = GetItem(directory);
                    btvi.ItemSelected = this.ItemSelected;
                    item.Items.Add(btvi);
                }
            }
        }

        private void ExploreFiles(TreeViewItem item)
        {
            var directoryInfo = (DirectoryInfo)null;
            if (item.Tag is DriveInfo)
            {
                directoryInfo = ((DriveInfo)item.Tag).RootDirectory;
            }
            else if (item.Tag is DirectoryInfo)
            {
                directoryInfo = (DirectoryInfo)item.Tag;
            }
            else if (item.Tag is FileInfo)
            {
                directoryInfo = ((FileInfo)item.Tag).Directory;
            }
            if (object.ReferenceEquals(directoryInfo, null)) return;
            foreach (var file in directoryInfo.GetFiles())
            {
                var isHidden = (file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
                var isSystem = (file.Attributes & FileAttributes.System) == FileAttributes.System;

                String extention = file.Extension; //gets the file's extention
                var isMP3 = extention.ToLower().Equals(".mp3"); //checks if the file is MP3
                var isWAV = extention.ToLower().Equals(".wav"); //checks if the file is WAV
                if (!isHidden && !isSystem && (isMP3 || isWAV)) //if the file is not a hidden system file or an MP3, WAV
                {
                    // this.ocCurrentSongsInDict.Add(new SongClass(file));
                    //item.Items.Add(this.GetItem(file));
                }
            }
        } 
        #endregion

        #region Public methods
        public void AddDummy(TreeViewItem item)
        {
            item.Items.Add(new DummyTreeViewItem());
        }

        public bool HasDummy(TreeViewItem item)
        {
            return item.HasItems && (item.Items.OfType<TreeViewItem>().ToList().FindAll(tvi => tvi is DummyTreeViewItem).Count > 0);
        }

        public void RemoveDummy(TreeViewItem item)
        {
            var dummies = item.Items.OfType<TreeViewItem>().ToList().FindAll(tvi => tvi is DummyTreeViewItem);
            foreach (var dummy in dummies)
            {
                item.Items.Remove(dummy);
            }
        }


        #endregion

        #region Public static
        public static DriveTreeViewItem GetItem(DriveInfo drive)
        {
            var item = new DriveTreeViewItem(drive);
            item.AddDummy(item);
            return item;
        }


        public static DirectoryTreeViewItem GetItem(DirectoryInfo directory)
        {
            var item = new DirectoryTreeViewItem(directory);

            item.AddDummy(item);

            return item;
        }

        public static FileTreeViewItem GetItem(FileInfo file)
        {
            var item = new FileTreeViewItem(file);
            return item;
        }

        #endregion
    }
}
