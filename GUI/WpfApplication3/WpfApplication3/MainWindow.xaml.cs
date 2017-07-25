using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using MusicClassificationBL;
using MusicClassificationGui.ViewModel;

namespace MusicClassificationGui
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        private int AutoPlayDisc = 0;

		public MainWindow()
		{
			this.InitializeComponent();
			// Insert code required on object creation below this point.
            this.FileManagerControl.SongSelected += FileManagerControl_SongSelected;
            this.FileManagerControl.AutoPlay += FileManagerControl_AutoPlay;
            this.FileManagerControl.evnPlayingSong += FileManagerControl_evnPlayingSong;
            this.VolumeControl.DockLeftVolumeChanged += VolumeControl_DockLeftVolumeChanged;
            this.VolumeControl.DockRightVolumeChanged += VolumeControl_DockRightVolumeChanged;
            this.LeftDock.AutoNextSong += Dock_AutoNextSong;
            this.RightDock.AutoNextSong += Dock_AutoNextSong;
		}

        SongProp FileManagerControl_evnPlayingSong()
        {
            if (this.LeftDock.IsPlaying)
            {
                return this.LeftDock.GetLoadedSong();
            }
            if (this.RightDock.IsPlaying)
            {
                return this.RightDock.GetLoadedSong();
            }
            return null;
        }

        void Dock_AutoNextSong()
        {
            this.FileManagerControl.AskNextSong();
        }


        void FileManagerControl_AutoPlay(SongProp obj)
        {
            SongClass sc = new SongClass(obj);
            if (AutoPlayDisc==0)
            {
                if (LeftDock.IsPlaying == false)
                {
                    AutoPlayDisc = 1;
                    this.LeftDock.LoadSong(sc);
                    return;
                }
                if (RightDock.IsPlaying == false)
                {
                    AutoPlayDisc = 2;
                    this.RightDock.LoadSong(sc);
                    return;
                }
                this.LeftDock.LoadSong(sc);
                AutoPlayDisc = 1;
                return;
            }
            if (AutoPlayDisc ==1)
            {
                this.LeftDock.LoadSong(sc,true);
            }
            else if (AutoPlayDisc ==2)
            {
                this.RightDock.LoadSong(sc,true);
            }

        }

        #region VolumeControlEvents
        void VolumeControl_DockRightVolumeChanged(double obj)
        {
            this.RightDock.VolumeChanged(obj);
        }

        void VolumeControl_DockLeftVolumeChanged(double obj)
        {
            this.LeftDock.VolumeChanged(obj);
        } 
        #endregion

        void FileManagerControl_SongSelected(SongProp obj)
        {
            SongClass sc = new SongClass(obj);
            if (LeftDock.IsPlaying==false)
            {
                this.LeftDock.LoadSong(sc);
                return;
            }
            if (RightDock.IsPlaying == false)
            {
                this.RightDock.LoadSong(sc);
                return;
            }
            this.LeftDock.LoadSong(sc);
        }

        

	}
}