using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongKMeans: Algorithe<SongVector>
    {
        public static ClusterList<SongVector> RunKMeans(SongVectorList Points, int k, IDistance<SongVector> df, ICenterSelection<SongVector> cs)
        {
            return Algorithe<SongVector>.RunKMeans(Points, k, df,cs);
        }

        public event Action<int> Kmeans;

        private ClusterList<SongVector> m_clusClusters;
        private SongVectorList m_SongVectorList;
        private IDistance<SongVector> m_dfDIstanceFunction;
        private ICenterSelection<SongVector> m_csCenterSelection;

        private SongKMeans(SongVectorList Points, IDistance<SongVector> df, ICenterSelection<SongVector> cs)
        {
            this.m_SongVectorList = Points;
            this.m_dfDIstanceFunction = df;
            this.m_csCenterSelection = cs;
            Kmeans += SongKMeans_Kmeans;
        }

        void SongKMeans_Kmeans(int k)
        {
            m_clusClusters = Algorithe<SongVector>.RunKMeans(m_SongVectorList, k, m_dfDIstanceFunction, m_csCenterSelection);
        }

        public void Run(int k)
        {
            if (this.Kmeans!=null)
            {
                this.Kmeans(k);
            }
        }
    }
}
