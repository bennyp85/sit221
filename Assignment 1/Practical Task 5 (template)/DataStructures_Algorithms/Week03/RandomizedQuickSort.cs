using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public class RandomizedQuickSort : ISorter
    {
        private Random random = new Random();

        public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            RecursivePart<T>(sequence, 0, sequence.Length - 1, comparer);
        }

        private void RecursivePart<T>(T[] sequence, int left, int right, IComparer<T> comparer_)
        {
            if (left < right)
            {
                int q = RandomizedPartition(sequence, left, right, comparer_);
                RecursivePart(sequence, left, q - 1, comparer_);
                RecursivePart(sequence, q + 1, right, comparer_);
            }
        }

        private int RandomizedPartition<T>(T[] sequence, int left, int right, IComparer<T> comparer_)
        {
            int i = random.Next(left, right);
            T pivot = sequence[i];
            sequence[i] = sequence[right];
            sequence[right] = pivot;

            return Partition(sequence, left, right, comparer_);
        }

        private int Partition<T>(T[] sequence, int left, int right, IComparer<T> comparer_)
        {
            T pivot = sequence[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (comparer_.Compare(sequence[j], pivot) < 0) 
                {
                    Swap<T>(ref sequence[j], ref sequence[i]);

                    i++;
                }
            }

            sequence[right] = sequence[i];
            sequence[i] = pivot;

            return i;
        }

        private void Swap<T>(ref T t1, ref T t2)
        {
            T tmp = t2;
            t2 = t1;
            t1 = tmp;
        }

    }

}
