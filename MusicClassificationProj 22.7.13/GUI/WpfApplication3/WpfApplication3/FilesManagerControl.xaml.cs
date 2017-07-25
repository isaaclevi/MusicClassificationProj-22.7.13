using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using System.Collections.ObjectModel;
using MusicClassificationBL;
using MusicClassificationGui.ViewModel;
using MusicClassificationAlgotihm;

namespace MusicClassificationGui
{
    
	/// <summary>
	/// Interaction logic for FilesManagerControl.xaml
	/// </summary>
	public partial class FilesManagerControl : UserControl
	{
        public delegate SongProp dgPlayingSong();

        public event Action<SongProp> SongSelected;
        public event Action<SongProp> AutoPlay;
        public event dgPlayingSong evnPlayingSong;
        private Point _startPoint;
        private bool IsDragging;
        private bool m_bAutoPlay;

		public FilesManagerControl()
		{
			this.InitializeComponent();

            this.SongsFileBrower.SongSelected += SongsFileBrower_SongSelected;

		}

        void SongsFileBrower_SongSelected(SongProp obj)
        {
            if (this.SongSelected!=null)
            {
                this.SongSelected(obj);
            }
        }

        private void Grid_DoubleClick(object sender, RoutedEventArgs e)
        {
            if (this.dgPlayList.SelectedItem == null)
                return; // return if there's no row selected

            SongProp sp = this.dgPlayList.SelectedItem as SongProp;
            if (this.SongSelected != null)
            {
                this.SongSelected(sp);
            }
        }

        private void dgPlayList_Drop(object sender, DragEventArgs e)
        {
            SongPropList spl =this.Resources["PlayList"] as SongPropList;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string item in files)
                {
                    SongProp p = new SongProp(item);
                    spl.Add(p);
                    ((DataGrid)sender).GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();

                }

            }
            else if (e.Data.GetDataPresent(typeof(SongPropList)))
            {
                SongPropList spl1 = e.Data.GetData(typeof(SongPropList)) as SongPropList;
                foreach (SongProp item in spl1)
                {
                    spl.Add(item);
                }
            }
            
        }

        private void dgPlayList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(null);
        }

        private void dgPlayList_PreviewMouseMove(object sender, MouseEventArgs e)
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



        private void StartDrag(MouseEventArgs e)
        {
            IsDragging = true;
            SongProp sp = this.dgPlayList.SelectedItem as SongProp;
            if (sp!=null)
            {
                DragDropEffects de = DragDrop.DoDragDrop(this.dgPlayList, sp, DragDropEffects.Move);
            }
            IsDragging = false;
        }

        private void AutoPlaylist_Click(object sender, RoutedEventArgs e)
        {

            this.m_bAutoPlay = !m_bAutoPlay;
            
            if (this.AutoPlay!=null && this.m_bAutoPlay && this.dgPlayList.Items.Count>0)
            {
                SongProp currSong = null;
                if (this.dgPlayList.SelectedItem != null)
                    currSong = this.dgPlayList.SelectedItem as SongProp;
                else
                {

                    currSong = this.dgPlayList.Items[0] as SongProp;
                    this.dgPlayList.SelectedItem = currSong; 
                }
                this.AutoPlay(currSong);
            }
        }

        internal void AskNextSong()
        {
            Dispatcher.Invoke(new Action(NextSong));

        }

        private void NextSong()
        {
            int CurrSongIndex = this.dgPlayList.SelectedIndex;
            if (this.dgPlayList.Items.Count > CurrSongIndex + 1)
            {
                SongProp sp = this.dgPlayList.Items[CurrSongIndex + 1] as SongProp;
                this.dgPlayList.SelectedItem = this.dgPlayList.Items[CurrSongIndex + 1];
                if (this.AutoPlay != null && this.m_bAutoPlay)
                {
                    this.AutoPlay(sp);
                }
            }
            this.m_bAutoPlay = false;
        }

        private void clustering_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SongClass scPlayingSong=null;
            int k=4;
            SongPropList spl = this.Resources["PlayList"] as SongPropList;
            if (spl.Count < 7)
                k = spl.Count;
            
            SongList sl = new SongList();
            foreach (var item in spl)
	        {
                sl.Add(new SongClass(item));
	        }
            IDistance<SongVector> df = new Euclidean();
            //IDistance<SongVector> df = new Manhattan();
            ICenterSelection<SongVector> cs = new SongRandomSelection();
            ClusterList<SongVector> ClusterList = SongKMeans.RunKMeans(sl.GetSongsVectors(), k, df, cs);
            if (this.evnPlayingSong!=null)
            {
                SongProp sp= this.evnPlayingSong();
                if (sp!=null)
                {
                    scPlayingSong = new SongClass(sp);
                    ClusterList.SortByDistance(scPlayingSong.GetMusicVector(), df);
                }
            }

            spl.Clear();
            foreach (var currCluster in ClusterList)
            {
                foreach (var item in currCluster.Points)
	            {
                    spl.Add(item.Song.Property);
	            }
                
            }
            
            
        }
    }
}