using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClassificationAlgotihm
{
    public class FirstKPointCenters<T>: ICenterSelection<T> where T: IPoint<T>
    {
        public ListPoint<T> SelectCenters(ListPoint<T> Points, int Count)
        {
            ListPoint<T> Centers = new ListPoint<T>();
            for (int i = 0; i < Count; i++)
            {
                Centers.Add(Points[i]);
            }
            return Centers;
        }
    }
}
