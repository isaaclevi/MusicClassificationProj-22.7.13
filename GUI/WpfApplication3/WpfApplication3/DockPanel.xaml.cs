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
    /// Interaction logic for DockPanel.xaml
    /// </summary>
    public partial class DockPanel : UserControl
    {
        public event Action AutoNextSong
        {
            add {this.DiscControl.AutoNextSong += value;}
            remove { this.DiscControl.AutoNextSong -= value; }
        }




        public DockPanel()
        {
            this.InitializeComponent();
        }

        public bool IsPlaying
        {
            get { return DiscControl.IsPlaying; }
        }

        public SongProp GetLoadedSong()
        {
            return DiscControl.LoadedSong;
        }

        private void SongDroped(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                SongClass sc = new SongClass(files[0]);
                this.DiscControl.LoadSong(sc);
                this.SongData.LoadSong(sc);
                //this.SongData.LoadedSong = files[0];

            }
            else if (e.Data.GetDataPresent(typeof(SongProp)))
            {
                SongProp sp = e.Data.GetData(typeof(SongProp)) as SongProp;
                SongClass sc = new SongClass(sp);
                this.DiscControl.LoadSong(sc);
                this.SongData.LoadSong(sc);
            }
            else if (e.Data.GetDataPresent(typeof(SongPropList)))
            {
                SongPropList spl = e.Data.GetData(typeof(SongPropList)) as SongPropList;
                SongClass sc = new SongClass(spl[0]);
                this.DiscControl.LoadSong(sc);
                this.SongData.LoadSong(sc);
            }
        }

        public void LoadSong(SongClass song, bool toPlay = false)
        {
            if (this.DiscControl.IsPlaying && !toPlay)
            {
                MessageBoxResult mbr = MessageBox.Show("There is a playing song.\n Press \"Yes\" if you wnat to load new song, else press \"No\"", "Attantion"
                     , MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No, MessageBoxOptions.DefaultDesktopOnly);
                if (mbr == MessageBoxResult.No)
                {
                    return;
                }
            }
            this.DiscControl.Stop();
            this.DiscControl.LoadSong(song,toPlay);
            this.SongData.LoadSong(song);
        }


        internal void VolumeChanged(double obj)
        {
            this.DiscControl.ChangeVolume(obj);
        }

        private void Label_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effects == DragDropEffects.Copy)
            {
                e.UseDefaultCursors = false;
                Mouse.SetCursor(Cursors.Hand);
            }
            else
                e.UseDefaultCursors = true;

            e.Handled = true;
        }
    }
}