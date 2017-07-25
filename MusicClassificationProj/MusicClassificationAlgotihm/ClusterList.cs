using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClassificationAlgotihm
{
    public class ClusterList<T>:List<Cluster<T>> where T: IPoint<T>
    {
        protected virtual void ClusterBlong(T NewPoint,IDistance<T> DisFunc)
        {
            double minDistance = -1;
            Cluster<T> belongCluster = null;
            foreach (var item in this)
            {
                double distance = DisFunc.CalculateDistance(item.Centroid,NewPoint);
                if (minDistance== -1 || minDistance> distance)
                {
                    minDistance = distance;
                    belongCluster = item;
                }
            }
        }

    }
}
