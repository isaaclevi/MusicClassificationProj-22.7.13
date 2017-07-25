using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongRandomSelection :ICenterSelection<SongVector>
    {
        public ListPoint<SongVector> SelectCenters(ListPoint<SongVector> Points, int Count)
        {
            SongVectorList svl = new SongVectorList();
            Random r = new Random();
            for (int i = 0; i < Count; i++)
            {
                int index = r.Next(0,Points.Count);
                SongVector sv = Points[index];
                while (svl.Contains(sv))
                {
                    index = r.Next(0, Points.Count);
                    sv = Points[index];    
                }
                svl.Add(sv);
                Thread.Sleep(1);
            }
            return svl;
        }
    }
}
