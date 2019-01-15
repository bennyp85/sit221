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
            // we intitally point to the first element of the list via a private pointer of type Node<T>
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

        // When you do MoveNext(), first read the value of the pointer to the current, then do one step forward assigning pointer.Next to the pointer.
        // This should terminate when pointer is null.
        public bool MoveNext()
        {
            if (pointer!=null)
            {
                // this means we can proceed with the iteration process
                current = pointer.Value;
                pointer = pointer.Next;
                return true;
            }
            else
            {
                // this means that we cannot move forward anymore as the end of the list is met via the last element pointing to null
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
