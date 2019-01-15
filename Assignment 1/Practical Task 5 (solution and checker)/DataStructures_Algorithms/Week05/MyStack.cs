using DataStructures_Algorithms.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructures_Algorithms.Week05
{
    public class MyStack<T> : IEnumerable<T> where T : IComparable<T> 
    {
        private Vector<T> data = null;
        public MyStack()
        {
            data = new Vector<T>();
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
            return data[Count-1];
        }

        public T Pop()
        {
            if (Count == 0) throw new InvalidOperationException("The stack is empty");
            T item = data[Count - 1];
            data.RemoveAt(Count - 1);
            return item;
        }

        public void Push(T item)
        {
            data.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Iterator(data);
        }

        private class Iterator : IEnumerator<T>
        {
            private T current = default(T);
            private int position = -1;
            private Vector<T> data = null;

            public Iterator (Vector<T> data)
            {
                this.data = data;
            }

            public T Current
            {
                get { return current; }
            }

            object IEnumerator.Current
            {
                get { return current; }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (++position < data.Count)
                {
                    current = data[position];
                    return true;
                }
                else return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }

        public override string ToString()
        {
            if (Count == 0) return "[]";
            StringBuilder s = new System.Text.StringBuilder();
            s.Append("[");
            int k = 0;
            foreach (T element in this)
            {
                s.Append(element.ToString());
                if (k < Count - 1) s.Append(",");
                k++;
            }
            s.Append("]");
            return s.ToString();
        }
    }
}
