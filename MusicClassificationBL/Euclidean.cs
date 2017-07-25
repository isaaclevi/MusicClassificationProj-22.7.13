using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class Euclidean:IDistance<SongVector>
    {
        public double CalculateDistance(IPoint<SongVector> point, IPoint<SongVector> p)
        {
            SongVector point1 = (SongVector)point;
            SongVector point2 = (SongVector)p;
            double result = 0;
            for (int i = 0; i < point1.Wave.Length; i++)
            {
               result+= Math.Pow(point1.Wave[i]-point2.Wave[i], 2);
            }
            return Math.Sqrt(result);

        }


    }
         
}

