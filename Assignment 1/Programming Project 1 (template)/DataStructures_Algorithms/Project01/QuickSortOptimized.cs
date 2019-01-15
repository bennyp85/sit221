using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Project01
{
    public class QuickSortOptimized : ISorter
    {
        

        public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            QuickSort<T>(sequence, comparer, 0, sequence.Length-1);
        }

        public void QuickSort<T>(T[] S, IComparer<T> comparer, int a, int b)
        {
            if (a >= b) return;
            int left = a;
            int right = b - 1;
            T pivot = S[b];
            T temp;
            while(left <= right)
            {
                while (left <= right && comparer.Compare(S[left], pivot) < 0) { left++; }
                while (left <= right && comparer.Compare(S[right], pivot) > 0) { right--; }
                if(left <= right)
                {
                    temp = S[left]; S[left] = S[right]; S[right] = temp;
                    left++; right--;
                }

            }
            temp = S[left]; S[left] = S[b]; S[b] = temp;
            QuickSort(S, comparer, a, left - 1);
            QuickSort(S, comparer, left + 1, b);
        }
    }
}
