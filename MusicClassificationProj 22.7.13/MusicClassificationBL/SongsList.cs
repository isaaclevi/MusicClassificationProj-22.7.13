using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongsList:ListPoint<SongVector>
    {
        public SongsList()
        {
            
        }

        public override SongVector getCenterPoint()
        {
            return base.getCenterPoint();
        }
    }
}
