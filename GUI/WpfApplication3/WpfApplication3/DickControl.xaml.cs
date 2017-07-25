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
using MusicClassificationBL;

namespace MusicClassificationGui
{
	/// <summary>
	/// Interaction logic for dockPanelControl.xaml
	/// </summary>
	public partial class DickControl : UserControl
	{
        #region Members
        
        private SongClass m_loadedSong;
        private float m_fVolume;
        
        #endregion

        #region Delegates

        public delegate void dlgSongLoaded(SongClass song);
        
        #endregion

        #region Events
        public event dlgSongLoaded OnSongLoaded;
        private event Action NextSong;

        public event Action AutoNextSong
        {
            add { this.NextSong += value; }
            remove { this.NextSong -= value; }
        }


        #endregion


        #region DependencyProperty

        // Using a DependencyProperty as the backing store for SongLoaded.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SongLoadedProperty =
            DependencyProperty.Register("SongLoaded", typeof(bool), typeof(DickControl), new UIPropertyMetadata(false));
        // Using a DependencyProperty as the backing store for IsPlaying.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPlayingProperty =
            DependencyProperty.Register("IsPlaying", typeof(bool), typeof(DickControl), new PropertyMetadata(false));
        
        #endregion


        
        public SongProp LoadedSong
        {
            get { return this.m_loadedSong.Property; }
        }

        public bool IsPlaying
        {
            get { return (bool)GetValue(IsPlayingProperty); }
            set { SetValue(IsPlayingProperty, value); }
        }

        public bool SongLoaded
        {
            get { return (bool)GetValue(SongLoadedProperty); }
            set { SetValue(SongLoadedProperty, value); }
        }


        public DickControl()
		{
			this.InitializeComponent();
            this.m_fVolume = 1.0f;
            this.IsPlaying = false;
            this.SongLoaded = false;
		}

        public void LoadSong(SongClass Song,bool toPlay=false)
        {
            if (this.m_loadedSong != null && this.SongLoaded)
            {
                this.m_loadedSong.Stop();
                this.SongLoaded = false;
            }
            this.m_loadedSong = Song;
            this.m_loadedSong.SongEnded += m_loadedSong_SongEnded;
            this.SongLoaded = true;
            if (toPlay)
            {
                this.m_loadedSong.Play();
            }
            this.m_loadedSong.Volume = m_fVolume;
            //fire the event when the song has been loaded
            if (this.OnSongLoaded != null)
            {
                this.OnSongLoaded(this.m_loadedSong);
            }
        }

        void m_loadedSong_SongEnded()
        {
            if (this.NextSong!=null)
            {
                this.NextSong();
            }
        }


        private void PlayButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.m_loadedSong != null)
            {
                this.m_loadedSong.Play();
                this.IsPlaying = true;
            }

        }

        /// <summary>
        /// On pause button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PauseButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.m_loadedSong != null)
            {
                this.m_loadedSong.Pause();
                this.IsPlaying = false;
            }
        }

        /// <summary>
        /// stop to play the loaded song
        /// </summary>
        public void Stop()
        {
            if (this.m_loadedSong != null)
            {
                this.m_loadedSong.Stop();
                this.IsPlaying = false;
            }
        }

        /// <summary>
        /// Change the volume of the playing song
        /// </summary>
        /// <param name="obj"></param>
        internal void ChangeVolume(double obj)
        {
            if (this.m_loadedSong!=null)
            {
                this.m_loadedSong.Volume = (float)obj;    
            }
            
            this.m_fVolume = (float)obj;
        }
    }
}