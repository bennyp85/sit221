using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public class SelectionSort : ISorter
    {
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[j], array[min]) == -1)
                    {
                        min = j;
                    }
                    if(min != i)
                    {
                        var temp = array[i];
                        array[i] = array[min];
                        array[min] = temp;
                    }
                }
            }
        }
    }
}
