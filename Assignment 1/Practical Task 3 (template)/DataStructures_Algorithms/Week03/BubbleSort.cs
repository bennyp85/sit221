using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public class BubbleSort : ISorter
    {
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {

            for (int i = 1; i < array.Length; i++)
            {
                int swaps = 0;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j+1]) == 1)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swaps += 1;
                    }
                }
                if (swaps == 0) break;
            }
        }

    }
}
