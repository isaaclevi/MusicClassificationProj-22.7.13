using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClassificationAlgotihm
{
    public interface ICenterSelection<T> where T :IPoint<T>
    {
        ListPoint<T> SelectCenters(ListPoint<T> Points,int Count);
    }
}
