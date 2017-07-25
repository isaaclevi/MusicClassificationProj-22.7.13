using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicClassificationAlgotihm;

namespace MusicClassificationAlgotihm
{
    
    public class Algorithe<T> where T :IPoint<T>
    {
        /// <summary>
        /// run the k-means algorithm
        /// </summary>
        /// <param name="k">k clusters</param>
        /// <param name="df">distance function</param>
        public static ClusterList<T> RunKMeans(ListPoint<T> Points, int k, IDistance<T> df,ICenterSelection<T> cs)
        {
            int count=0;
            ClusterList<T> cl = new ClusterList<T>();
            bool isChange = true;

            if (k<=0)
            {
                Console.WriteLine("clusters amount error");
                return null ;
            }

            ListPoint<T> centers = Points.SelectCenters(cs,k);
            //defind the k point as a centers of the clusters
            foreach (T center in centers)
            {
                Cluster<T> c = new Cluster<T>(center,Points.GetType());
                cl.Add(c);
            }

            while (isChange)
            {
                Console.WriteLine(count++ + " Round");
                Console.WriteLine();
                //config each point to cluster
                foreach (T point in Points)
                {
                    double Min = -1;
                    Cluster<T> CurrMinCluster = null;
                    foreach (var clus in cl)
                    {
                        //calculate the distance bettween the point the curr Centroind
                        double CurrDistance = df.CalculateDistance(point, clus.Centroid);
                        //Console.Write(CurrDistance+ " ");
                        if (CurrMinCluster == null || Min > CurrDistance)
                        {
                            Min = CurrDistance;
                            CurrMinCluster = clus;
                        }
                    }
                    //Console.WriteLine();
                    CurrMinCluster.AddPoint(point);
                }

                isChange = false;
                ClusterList<T> newCl = new ClusterList<T>();
                //check if the centroid had been changed
                foreach (var clus in cl)
                {
                    Cluster<T> c = clus.CalcNewCenter(df);
                    if (!c.Centroid.Equals(clus.Centroid))
                    {
                        isChange = true;
                    }
                    //add the new cluster to new cluster list
                    newCl.Add(c);
                }

                //update the clusters centroinds
                if (isChange)
                {
                    cl = newCl;
                }
            }
            return cl;
        }

            
    }
}
