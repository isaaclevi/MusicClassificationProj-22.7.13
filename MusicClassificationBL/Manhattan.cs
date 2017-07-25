using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class Manhattan:IDistance<SongVector>
    {
        public double CalculateDistance(IPoint<SongVector> point, IPoint<SongVector> p)
        {
            SongVector point1 = (SongVector)point;
            SongVector point2 = (SongVector)p;
            double AB = 0;

            for (int i = 0; i < point1.Wave.Length; i++)
            {
                AB += Math.Pow(Math.Pow(point1.Wave[i] - point2.Wave[i], 2), 0.5);
            }
            return AB;
        }
    }
}
