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
	/// Interaction logic for SongDataControl.xaml
	/// </summary>
	public partial class SongDataControl : UserControl
	{
        private SongClass m_loadedSong;

        public bool IsSongLoaded
        {
            get { return (bool)GetValue(IsSongLoadedProperty); }
            set { SetValue(IsSongLoadedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSongLoaded.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSongLoadedProperty =
            DependencyProperty.Register("IsSongLoaded", typeof(bool), typeof(SongDataControl), new PropertyMetadata(false));

        public SongDataControl()
        {
            this.InitializeComponent();
            this.IsSongLoaded = false;
        }

 
        private void SongWaveDisplay(SongVector songVect)
        {
            int Middle = (int)this.SongWave.ActualHeight / 2;
            double WaveWidth = this.SongWave.ActualWidth;
            int GraphOffset = 35;
            int GraphNirmul = 35;
            float Offset;
            float Nirmul;

            //Looking fot the min and max of points

            float Max = songVect.GetMax();
            float Min = songVect.GetMin();

            Nirmul = (Max + Min) / 2;
            Offset = (Max - Min) / 2;

            int[] data = new int[songVect.Lenght];
            //for (int i = 1; i < data.Length; i++)
            //{
            //    data[i] = GraphOffset - (int)((songVect.Wave[i] - Offset) / Nirmul * GraphNirmul);
            //}
            for (int i = 1; i < data.Length; i++)
            {
                data[i] = GraphOffset - (int)((songVect.Wave[i] - Offset) / Nirmul * GraphNirmul);
            }

            int Xcounter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                Line currLine = new Line()
                {
                    X1 = Xcounter,
                    Y1 = data[i],
                    X2 = Xcounter,
                    Y2 = 0,
                    //Set the color of the lines
                    StrokeThickness = 1,
                    Stroke = new SolidColorBrush(Colors.Yellow)
                };
                Xcounter++;
                this.SongWave.Children.Add(currLine);


            }

        }

        public void LoadSong(SongClass LoadedSong)
        {
            if (this.IsSongLoaded)
            {
                this.m_loadedSong.Dispose();
                this.IsSongLoaded = false;
            }
            this.DataContext = LoadedSong;
            this.m_loadedSong = LoadedSong;
            //SongVector dispVector = this.m_loadedSong.GetMusicWave(new TimeSpan(0, 0, 0), this.m_loadedSong.Duration);
            this.loadSongProp();
            this.IsSongLoaded = true;
            //SongWaveDisplay(dispVector);
        }

        private void loadSongProp()
        {
           
        }

	}
}