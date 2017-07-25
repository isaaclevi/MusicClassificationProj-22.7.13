using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicClassificationGui.ViewModel;
using System.Linq;
using System.IO;
using MusicClassificationBL;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;

namespace MusicClassificationGui
{
    /// <summary>
    /// Interaction logic for SongsFileBrowser.xaml
    /// </summary>
    public partial class SongsFileBrowser : UserControl
    {
        public event Action<SongProp> SongSelected;

        private ObservableCollection<SongProp> m_sp;
        private Point _startPoint;

        public SongsFileBrowser()
        {
            this.InitializeComponent();
            this.LoadDirectories();
            m_sp = new ObservableCollection<SongProp>();
            this.dgSongsGrid.DataContext = this.m_sp;
            this.dgSongsGrid.Items.Refresh();

        }


        public void LoadDirectories()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                this.tvBrowser.Items.Add(BrowserTreeViewItem.GetItem(drive));
            }

            foreach (BrowserTreeViewItem item in this.tvBrowser.Items)
            {
                item.ItemSelected += item_ItemSelected;
            }

        }

        void item_ItemSelected(ObservableCollection<SongProp> obj)
        {
            if (obj.Count > 0)
            {
                this.m_sp = obj;
                this.dgSongsGrid.DataContext = obj;
                this.dgSongsGrid.Items.Refresh();
            }
        }

        private void Grid_DoubleClick(object sender, RoutedEventArgs e)
        {
            if (this.dgSongsGrid.SelectedItem == null)
                return; // return if there's no row selected

            SongProp sp = this.dgSongsGrid.SelectedItem as SongProp;
            if (this.SongSelected != null)
            {
                this.SongSelected(sp);
            }
        }

        private void dgSongsGrid_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && !IsDragging)
            {
                Point position = e.GetPosition(null);

                if (Math.Abs(position.X - _startPoint.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(position.Y - _startPoint.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    StartDrag(e);

                }
            }
        }

        private void dgSongsGrid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(null);
        }

        private void StartDrag(MouseEventArgs e)
        {
            //GiveFeedbackEventHandler handler = new GiveFeedbackEventHandler(DragSource_GiveFeedback);
            //this.dgSongsGrid.GiveFeedback += handler; 
            IsDragging = true;
            SongPropList spl = new SongPropList();
            foreach (var item in this.dgSongsGrid.SelectedItems)
            {
                spl.Add(item as SongProp);
            }


            DragDropEffects de = DragDrop.DoDragDrop(this.dgSongsGrid, spl, DragDropEffects.Move);
            IsDragging = false;
        }

        public bool IsDragging { get; set; }

        void DragSource_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            try
            {
                //This loads the cursor from a stream .. 
                if (_allOpsCursor == null)
                {
                        _allOpsCursor = new Cursor("\\Cursers\\Disc.cur");
                }
                Mouse.SetCursor(_allOpsCursor);

                e.UseDefaultCursors = false;
                e.Handled = true;
            }
            finally { }
        }

        public System.Windows.Input.Cursor _allOpsCursor { get; set; }
    }
}