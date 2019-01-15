using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public interface ISorter
    {
        void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>;
    }
}
