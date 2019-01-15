using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public class BubbleSort : ISorter
    {

        public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = 0; j < sequence.Length - i - 1; j++)
                {
                    if (comparer.Compare(sequence[j], sequence[j + 1]) > 0) Swap(ref sequence[j], ref sequence[j + 1]);
                }
            }
        }

        private void Swap<T>(ref T t1, ref T t2)
        {
            T tmp = t2;
            t2 = t1;
            t1 = tmp;
        }

    }
}
