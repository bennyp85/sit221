using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public interface ISorter
    {
        void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>;

    }
}
