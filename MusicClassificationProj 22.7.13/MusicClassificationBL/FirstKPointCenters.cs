using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class FirstKPointCenters: ICenterSelection<SongVector> 
    {
        public ListPoint<SongVector> SelectCenters(ListPoint<SongVector> Points, int Count)
        {
            ListPoint<SongVector> Centers = new ListPoint<SongVector>();
            for (int i = 0; i < Count; i++)
            {
                Centers.Add(Points[i]);
            }
            return Centers;
        }
    }
}
