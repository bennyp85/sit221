using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public interface ISorter
    {
        void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>;
    }
}
