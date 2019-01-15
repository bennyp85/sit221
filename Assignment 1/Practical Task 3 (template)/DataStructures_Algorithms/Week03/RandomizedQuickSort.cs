/***************************************************************************************
*    Title: Randomized Quick Sort in C#
*    Author: Yi-Fan Liao
*    Date: 31/7/18
*    Availability: https://begeeben.wordpress.com/2012/08/22/randomized-quick-sort-in-c/          
***************************************************************************************/

using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public class RandomizedQuickSort : ISorter
    {
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            QuickSort(array, comparer, 0, array.Length-1);

        }

        private void QuickSort<T>(T[] array, IComparer<T> comparer, int left, int right) where T : IComparable<T>
        {

            if (left < right)
            {
                int q = Partition(array, comparer, left, right);
                QuickSort(array, comparer, left, q - 1);
                QuickSort(array, comparer, q + 1, right);

            }
        }

        private int RandomizedPartition<T>(T[] array, IComparer<T> comparer, int left, int right) where T : IComparable<T>
        {
            Random random = new Random();
            int i = random.Next(left, right);

            var pivot = array[i];
            array[i] = array[right];
            array[right] = pivot;

            return Partition(array, comparer, left, right);
        }

        private int Partition<T>(T[] array, IComparer<T> comparer, int left, int right) where T : IComparable<T>
        {
            var pivot = array[right];
            var temp = array[0];

            int i = left;
            for (int j = left; j < right; j++)
            {
                if(comparer.Compare(array[j], pivot) == -1 || comparer.Compare(array[j], pivot )== 0)
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                }
            }
            array[right] = array[i];
            array[i] = pivot;
            return i;
        }
    }
}
