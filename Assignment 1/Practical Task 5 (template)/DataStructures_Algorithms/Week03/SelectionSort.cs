using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{

    public class SelectionSort : ISorter
    {

        public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            long index_of_min = 0;
            for (int iterator = 0; iterator < sequence.Length - 1; iterator++)
            {
                index_of_min = iterator;
                for (int index = iterator + 1; index < sequence.Length; index++)
                {
                    if (comparer.Compare(sequence[index], sequence[index_of_min]) < 0)
                        index_of_min = index;
                }
                Swap(ref sequence[iterator], ref sequence[index_of_min]);
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
