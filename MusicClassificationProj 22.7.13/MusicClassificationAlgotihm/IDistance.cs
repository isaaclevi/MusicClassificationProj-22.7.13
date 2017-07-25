using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicClassificationAlgotihm
{
    public interface IDistance<T>
    {
        double CalculateDistance(IPoint<T> point, IPoint<T> p);
    }
}