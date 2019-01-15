using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public class MergeSortBottomUp : ISorter
    {
        public void Sort<T>(T[] sequeunce, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            mergeSortBottomUp<T>(sequeunce, comparer);
        }

        public void Merge<T>(T[] in1, T[] out1, IComparer<T> comparer, int start, int inc)
        {
            int end1 = Math.Min(start + inc, in1.Length);
            int end2 = Math.Min(start + 2 * inc, in1.Length);
            int x = start;
            int y = start + inc;
            int z = start;
            while (x < end1 && y < end2)
            {
                if (comparer.Compare(in1[x], in1[y]) < 0) { out1[z++] = in1[x++]; }
                else { out1[z++] = in1[y++]; }
                if (x < end1) { Array.Copy(in1, x, out1, z, end1 - x); }
                else if (y < end2) { Array.Copy(in1, y, out1, z, end2 - y); }
            }
        }

        public void mergeSortBottomUp<T>(T[] orig, IComparer<T> comparer)
        {
            int n = orig.Length;
            T[] src = orig;
            T[] dest = new T[n];
            T[] temp;
            for (int i = 1; i < n; i *= 2)
            {
                for (int j = 0; j < n; j += 2 * i)
                
                    Merge(src, dest, comparer, j, i);
                    temp = src; src = dest; dest = temp;
                
            }
            if (orig != src) { Array.Copy(src, 0, orig, 0, n); }
        }
    }
}
