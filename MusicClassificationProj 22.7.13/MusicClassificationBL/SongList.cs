using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClassificationBL
{
    public class SongList:List<SongClass>
    {

        /// <summary>
        /// get the vectors of all the belongs songs
        /// </summary>
        /// <returns></returns>
        public SongVectorList GetSongsVectors()
        {
            SongVectorList svl = new SongVectorList();
            foreach (var item in this)
            {
                svl.Add(item.GetMusicVector());
            }
            svl.RemoveAll(x=>x==null);
            return svl;
        }

    }
} 
