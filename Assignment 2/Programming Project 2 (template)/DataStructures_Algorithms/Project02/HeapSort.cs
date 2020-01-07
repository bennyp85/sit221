using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project02
{
    public class HeapSort : ISorter
    {
        public HeapSort()
        {
        }

        public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        private class DefaultComparer<D, K> : IComparer<IHeapifyable<D, K>>
        {
            public int Compare(IHeapifyable<D, K> x, IHeapifyable<D, K> y)
            {
                return Comparer<K>.Default.Compare(x.Key, y.Key);
            }
        }
    }
}
