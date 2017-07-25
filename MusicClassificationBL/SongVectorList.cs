using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongVectorList:ListPoint<SongVector>
    {
        public SongVectorList()
        {
            
        }

        public override SongVector getCenterPoint(IDistance<SongVector> df)
        {
            float[] avgWav = new float[this[0].Lenght];

            for (int i = 0; i < avgWav.Length; i++)
            {
                avgWav[i] = this.Average(wav=> wav.Wave[i]);
            }
            SongVector svAvgWav = new SongVector(avgWav);

            SongVector svCloserVector = null;
            double dDistance = 0;

            foreach (var item in this)
            {
                double currDistance = df.CalculateDistance(item, svAvgWav);
                if (svCloserVector==null|| currDistance<dDistance)
                {
                    svCloserVector = item;
                    dDistance = currDistance;
                }
            }
            return svCloserVector;
        }

        public override ListPoint<SongVector> SelectCenters(ICenterSelection<SongVector> cs,int k)
        {
            return cs.SelectCenters(this, k);
        }
    }

   
}
