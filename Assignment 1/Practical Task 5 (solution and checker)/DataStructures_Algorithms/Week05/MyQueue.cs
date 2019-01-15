using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week04;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week05
{
    public class MyQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private DoubleLinkedList<T> data = null;
        public MyQueue()
        {
            data = new DoubleLinkedList<T>();
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Contains(T item)
        {
            return data.Contains(item);
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException("The stack is empty");
            return data.First.Value;
        }

        public T Dequeue()
        {
            if (Count == 0) throw new InvalidOperationException("The stack is empty");
            T item = data.First.Value;
            data.RemoveFirst();
            return item;
        }

        public void Enqueue(T item)
        {
            data.AddLast(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public override string ToString()
        {
            return data.ToString();
        }

    }
}
