using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MusicClassificationBL;

namespace MusicClassificationGui.ViewModel
{
    public  class SongsFilesList
    {
        private ObservableCollection<SongProp> m_ocSongPropList = new ObservableCollection<SongProp>();
        public ObservableCollection<SongProp> GetSongList()
        {
            if (m_ocSongPropList!=null)
            {
                m_ocSongPropList = new ObservableCollection<SongProp>();
            }
            return m_ocSongPropList;
        }

    }
}
