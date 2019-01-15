/***************************************************************************************
*    Title: Binary Search using Recursion in C#
*    Author: Sajjad Arif Gul
*    Date: 3/8/18
*    Availability: https://www.csharpens.com/c-sharp/binary-search-using-recursion-in-c-sharp-68/
***************************************************************************************/

using System;
using System.Collections.Generic;
using DataStructures_Algorithms.Week03;

namespace DataStructures_Algorithms.Week01
{

    [Serializable]
    public class Vector<T> where T : IComparable<T>
    {

        private const int DEFAULT_CAPACITY = 10000;
        private T[] data;
        private int count = 0;

        public Vector()
        {
            data = new T[DEFAULT_CAPACITY];
            // connect Sorter to the DeafultSorter 
            Sorter = new DefaultSorter();
        }

        public Vector(int CAPACITY)
        {
            data = new T[CAPACITY];
            // connect Sorter to the DeafultSorter 
            Sorter = new DefaultSorter();
        }

        private void ExtendData(int extensionCapacity)
        {
            T[] newData = new T[data.Length + extensionCapacity];
            for (var i = 0; i < count; i++) newData[i] = data[i];
            data = newData;
        }

        public int Capacity
        {
            get { return data.Length; }
            set
            {
                if (value < data.Length) throw new ArgumentException();
                ExtendData(value - data.Length);
            }
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(T element)
        {
            if (count == data.Length) ExtendData(DEFAULT_CAPACITY);
            data[count++] = element;
        }

        public void Insert(int index, T element)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();
            if (count == data.Length) ExtendData(DEFAULT_CAPACITY);
            for (int i = count; i > index; i--) data[i] = data[i - 1];
            data[index] = element;
            count++;
        }

        public void Clear()
        {
            data = new T[DEFAULT_CAPACITY]; //you can do so many different things here, this just a quick & dry one
            count = 0;
        }

        /*
 * Running time of IndexOf - T(n) = 3n + 2 [ details: 1 (init i) + [n+1] (condition checking) + n (increment i) + n (if condition checking) + 1 (return statement) ] 
 * IndexOf is O(n) [ neglicting constants and lower terms]
 * 
 */
        public int IndexOf(T element)
        {
            for (var i = 0; i < count; i++)
            {
                if (data[i].Equals(element)) return i;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            if (IndexOf(element) < 0) return false;
            return true;
        }

        public bool Remove(T element)
        {
            int index = IndexOf(element);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }


        public int RemoveAll(T element)
        {
            int ptr = 0;
            for (int i = 0; i < count; i++)
            {
                if (!data[i].Equals(element))
                {
                    data[ptr] = data[i];
                    ptr++;
                }
            }
            for (int i = ptr; i < count; i++) data[i] = default(T);
            int result = count - ptr;
            count = ptr;
            return result;
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();
            //shift all the elements to the left
            for (int i = index; i < count; i++) data[i] = data[i + 1];
            count--; //decrement count field
        }

        public T Max()
        {
            if (count == 0) return default(T);
            var comparer = Comparer<T>.Default;
            T max = data[0];
            for (var i = 1; i < count; i++)
            {
                if (comparer.Compare(data[i], max) > 0) max = data[i];
            }
            return max;
        }

        public T Min()
        {
            if (count == 0) return default(T);
            Comparer<T> comparer = Comparer<T>.Default;
            T min = data[0];
            for (var i = 1; i < count; i++)
            {
                if (comparer.Compare(data[i], min) < 0) min = data[i];
            }
            return min;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0) throw new IndexOutOfRangeException();
                return data[index];
            }
            set
            {
                if (index >= count || index < 0) throw new IndexOutOfRangeException();
                data[index] = value;
            }
        }

        public override string ToString()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            if (count == 0) return "[]";
            s.Append("[");
            for (int i = 0; i < count - 1; i++) s.Append(data[i] + ",");
            s.Append(data[count - 1] + "]");
            return s.ToString();
        }

        public void Sort()
        {
            Truncate();
            // link Sorter to this Sort method here
            Sorter.Sort(data, null);
        }

        public void Sort(IComparer<T> comparer)
        {
            Truncate();
            // link Sorter to this Sort method here
            Sorter.Sort(data, comparer);
        }

        private void Truncate()
        {
            T[] temp = new T[Count];
            Array.Copy(data, temp, Count);
            data = temp;
        }

        public int BinarySearch(IComparer<T> comparer, int first, int last, T value)
        {
            int middle = (first + last) / 2;
            if (comparer.Compare(data[middle], value) == 0) { return middle; }
            else if (first >= last) { return -1; }
            else if (comparer.Compare(value, data[middle]) == -1) { return BinarySearch(comparer, first, middle - 1, value); }
            else { return BinarySearch(comparer, middle + 1, last, value); }
        }

        public int BinarySearch(T item)
        {
            return (BinarySearch(null, 0, data.Length - 1, item));
        }

        int BinarySearch(T item, IComparer<T> comparer)
        {
            return (BinarySearch(comparer, 0, data.Length - 1, item));
        }


        public ISorter Sorter
        {
            get; set;
        }


        internal class DefaultSorter : ISorter
        {
            public void Sort<T>(T[] sequence, IComparer<T> comparer) where T : IComparable<T>
            {
                if (comparer == null) comparer = Comparer<T>.Default;
                Array.Sort(sequence, comparer);
            }
        }
    }
}


