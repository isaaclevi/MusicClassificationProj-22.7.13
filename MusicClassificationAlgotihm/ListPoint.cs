using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicClassificationAlgotihm
{
    public class ListPoint<T>:List<T> where T:IPoint<T>
    {



        #region Ctor
        public ListPoint()
        {
        }
        #endregion

        /// <summary>
        /// not emplement
        /// </summary>
        /// <param name="k">The number of the centers</param>
        /// <returns>null</returns>
        public virtual ListPoint<T> SelectCenters(ICenterSelection<T> CS,int k)
        {
            return CS.SelectCenters(this,k);
        }

        /// <summary>
        /// Not empliment
        /// </summary>
        /// <returns>null</returns>
        public virtual T getCenterPoint(IDistance<T> df)
        {
            throw new NotImplementedException("the method not Implemented");
        }

        private ListPoint<T> SelectRandomCenters()
        {
            return null;
        }


    }
}
