using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClassificationAlgotihm
{
    public class ClusterList<T> : Collection<Cluster<T>> where T : IPoint<T>
    {


        public virtual Cluster<T> ClusterBlong(T NewPoint, IDistance<T> DisFunc)
        {
            double minDistance = -1;
            Cluster<T> belongCluster = null;
            foreach (var item in this)
            {
                double distance = DisFunc.CalculateDistance(item.Centroid, NewPoint);
                if (minDistance == -1 || minDistance > distance)
                {
                    minDistance = distance;
                    belongCluster = item;
                }
            }
            return belongCluster;
        }

        //sort the clusters by distance from the given point 
        public void SortByDistance(T point, IDistance<T> DisFunk)
        {
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i+1; j < this.Count; j++)
                {
                    double distance1 = DisFunk.CalculateDistance(this[i].Centroid, point);
                    double distance2 = DisFunk.CalculateDistance(this[j].Centroid, point);
                    if (distance1>distance2)
                    {
                        Cluster<T> temp = this[i];
                        this[i] = this[j];
                        this[j] = temp;
                    }
                }
            }
        }


    }
}
