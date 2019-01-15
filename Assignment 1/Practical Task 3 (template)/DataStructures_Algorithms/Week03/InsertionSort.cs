using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public class InsertionSort : ISorter
    {
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while((j > 0) && comparer.Compare(array[j-1], array[j]) == 1)
                {
                    var temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j -= 1;
                }
            }
        }
    }
}
