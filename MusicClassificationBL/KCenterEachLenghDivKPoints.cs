using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class KCenterEachLenghDivKPoints : ICenterSelection<SongVector>
    {
        public ListPoint<SongVector> SelectCenters(ListPoint<SongVector> Points, int Count)
        {
            ListPoint<SongVector> centers = new ListPoint<SongVector>();
            int num =Points.Count / Count;
            for (int i = 0; i < Count; i++)
            {
                centers.Add(Points.ElementAt(i*num));
            }
            
            return centers;
        }
    }
}
