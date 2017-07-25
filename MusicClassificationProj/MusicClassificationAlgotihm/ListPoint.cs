using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicClassificationAlgotihm
{
    public class ListPoint<T>:List<T> where T:IPoint<T>
    {
        #region Members
        private ICenterSelection<T> m_PointSelection;
        
        #endregion
        #region Prop
        protected ICenterSelection<T> PointSelection
        {
            get { return m_PointSelection; }
            set { m_PointSelection = value; }
        } 
        #endregion

        #region Ctor
        public ListPoint()
        {
            this.m_PointSelection = new FirstKPointCenters<T>();
        }

        public ListPoint(ICenterSelection<T> PointSelection)
        {
            this.m_PointSelection = PointSelection;
        }

        #endregion

        /// <summary>
        /// not emplement
        /// </summary>
        /// <param name="k">The number of the centers</param>
        /// <returns>null</returns>
        public virtual ListPoint<T> SelectCenters(int k)
        {
            return this.m_PointSelection.SelectCenters(this,k);
        }

        /// <summary>
        /// Not empliment
        /// </summary>
        /// <returns>null</returns>
        public virtual T getCenterPoint()
        {
            throw new NotImplementedException("the method not Implemented");
        }

        private ListPoint<T> SelectRandomCenters()
        {
            return null;
        }


    }
}
