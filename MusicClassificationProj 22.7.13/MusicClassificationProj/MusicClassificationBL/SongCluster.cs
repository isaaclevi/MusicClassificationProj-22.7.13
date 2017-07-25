using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongCluster:Cluster<SongVector>
    {
        public SongCluster(SongVector Center):base(Center)
        {

        }
    }
}
