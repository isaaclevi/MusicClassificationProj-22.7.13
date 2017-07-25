using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicClassificationAlgotihm
{
    public class Cluster<T> where T: IPoint<T>
    {
        public T Centroid { get; set; }
        public ListPoint<T> Points { get; set;  }

        public Cluster(T centroid )
        {
            this.Centroid = centroid;
            this.Points = new ListPoint<T>();
        }

        /// <summary>
        /// Add New Point to the WineDataList
        /// </summary>
        /// <param name="Point">point that belong to the cluster</param>
        public void AddPoint(T Point)
        {
            this.Points.Add(Point);
        }

        /// <summary>
        /// check if the cluster is empty
        /// </summary>
        /// <returns>return true if the cluster is empty</returns>
        public bool isEmpty()
        {
            if (this.Points.Count==0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Calculate the sse of singel cluster
        /// </summary>
        /// <returns></returns>
        public double CalcSSE(IDistance<T> df)
        {
            double result = 0;
            foreach (IPoint<T> item in this.Points)
            {
                result += Math.Pow(df.CalculateDistance(item,this.Centroid),2);
            }

            return result;

        }

        /// <summary>
        /// get cluster with new center point
        /// </summary>
        /// <returns>cluster the the avg center point</returns>
        internal Cluster<T> CalcNewCenter()
        {
            T newCenter = this.Points.getCenterPoint();
            Cluster<T> c = new Cluster<T>(newCenter);
            return c;
        }

    }
}
