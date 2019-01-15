using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week04
{
    public class ListEnumerator<T> : IEnumerator<T>
    {
        private Node<T> pointer = null;
        private T current = default(T);
        private DoubleLinkedList<T> collection = null;

        public ListEnumerator(DoubleLinkedList<T> collection)
        {
            this.collection = collection;
            pointer = collection.First;
        }

        public T Current
        {
            get { return current; }
        }

        object IEnumerator.Current
        {
            get { return current; }
        }

        public bool MoveNext()
        {
            if (pointer!=null)
            {
                current = pointer.Value;
                pointer = pointer.Next;
                return true;
            }
            else
            {
                current = default(T);
                return false;
            }
        }

        public void Reset()
        {
            current = default(T);
            pointer = collection.First;
        }

        public void Dispose() { }

    }

}
