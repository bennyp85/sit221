using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public class MergeSortTopDown : ISorter
    {
         
        public void Sort<T>(T[] sequeunce,IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            MergeSort<T>(sequeunce , comparer);
        }
        public void Merge<T>(T[] S1, T[] S2, T[] S, IComparer<T> comparer)
        {
            int i = 0, j = 0;
            while (i + j < S.Length)
            {
                if (j == S2.Length || (i < S1.Length && comparer.Compare(S1[i], S2[j]) < 0))
                {
                    S[i+j] = S1[i++];
                }
                else
                {
                    S[i+j] = S2[j++];
                }
            }
        }

        public void MergeSort<T>(T[] S, IComparer<T> comparer)
        {
            int n = S.Length;
            if (n < 2) return;
            double mid = n / 2.0;
            int middle = (int)mid;
            int floor = (int)Math.Floor(mid);
            int ceiling = (int)Math.Ceiling(mid);
            T[] S1 = new T[floor];
            T[] S2 = new T[ceiling];
            Array.Copy(S, S1, middle);
            Array.Copy(S, middle, S2, 0, middle);
            MergeSort(S1, comparer);
            MergeSort(S2, comparer);
            Merge(S1, S2, S, comparer);
        }
    }
}
