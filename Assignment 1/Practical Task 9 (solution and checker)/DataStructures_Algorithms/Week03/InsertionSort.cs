using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public class InsertionSort : ISorter
    {

        public void Sort<T>(T[] sequence, IComparer<T> comparer)  where T: IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            int j = 0;
            T temp;
            for (int index = 1; index < sequence.Length; index++)
            {
                j = index;
                temp = sequence[index];
                while ((j > 0) && comparer.Compare(sequence[j - 1], temp) > 0)
                {
                    sequence[j] = sequence[j - 1];
                    j = j - 1;
                }
                sequence[j] = temp;
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