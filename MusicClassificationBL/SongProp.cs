using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;

namespace MusicClassificationBL
{
    public class SongProp : INotifyPropertyChanged
    {
        private string m_strFilePath;
        private File m_fileInfo;
        
        public SongProp(string FilePath)
        {
            this.m_strFilePath = FilePath;
            m_fileInfo = File.Create(this.m_strFilePath);
            
        }
        
        public String Name
        {
            get { return m_fileInfo.Name; }
            
        }

        public TimeSpan Duration
        {
            get { return m_fileInfo.Properties.Duration; }
        }

        public String Title
        {
            get { return m_fileInfo.Tag.Title; }
        }

        public String Artist
        {
            get { return m_fileInfo.Tag.FirstAlbumArtist; }
        }

        public String Album
        {
            get { return m_fileInfo.Tag.Album; }
        }

        public String Genre
        {
            get { return m_fileInfo.Tag.FirstGenre; }
        }

        public Int32 Year
        {
            get { return (Int32)m_fileInfo.Tag.Year; }
        }

        public Int32 BeatsPerMinute
        {
            get { return (Int32)m_fileInfo.Tag.BeatsPerMinute; }
        }

        public String Comment
        {
            get { return m_fileInfo.Tag.Comment; }
        }
        public Int32 AudioBitrate
        {
            get { return m_fileInfo.Properties.AudioBitrate; }
        }

        public Int32 AudioSampleRate
        {
            get { return m_fileInfo.Properties.AudioSampleRate; }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(object sender, string PropName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender, new PropertyChangedEventArgs(PropName));
            }
        }



       
    }

    public class SongPropList : ObservableCollection<SongProp>
    {
        public SongPropList()
        {
        }


    }
}
