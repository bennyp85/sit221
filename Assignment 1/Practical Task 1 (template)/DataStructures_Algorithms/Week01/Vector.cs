using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week01
{

    [Serializable]
    public class Vector<T> where T : IComparable<T>
    {
        T[] data;
        private const int DEFAULT_CAPACITY = 4;

        public Vector()
        {
            data = new T[DEFAULT_CAPACITY];
        }
        public Vector(int CAPACITY)
        {
            data = new T[CAPACITY];
        }

        int indexOfLastElement = 0;

        public void Add(T element)
        {
            if (Count < Capacity)
            {
                data[indexOfLastElement] = element;
                indexOfLastElement += 1;
            }
            else
            {
                T[] newArray = new T[Capacity * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    newArray[i] = data[i];
                }
                data = newArray;
                data[indexOfLastElement] = element;
                indexOfLastElement += 1;
            }
        }

        public void Insert(int index, T element)
        {
            try
            {
                if (index.CompareTo(data.Length) == 1)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                int indexOfLastElement = Count - 1;
                if (index < Capacity)
                {
                    indexOfLastElement += 1;
                    int shuffleLocation = indexOfLastElement;
                    while (shuffleLocation > index)
                    {
                        data[shuffleLocation] = data[shuffleLocation - 1];
                        shuffleLocation -= 1;
                    }
                    data[index] = element;
                }
                else
                {
                    T[] newArray = new T[index + 1];
                    for (int i = 0; i < data.Length; i++)
                    {
                        newArray[i] = data[i];
                    }
                    data = newArray;
                    data[index] = element;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid index {0}", e.Message);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = default(T);
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    data[i] = default(T);
                    return true;
                }
            }
            return false;
        }

        public int RemoveAll(T item)
        {
            int numberOfItemsRemoved = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    data[i] = default(T);
                    numberOfItemsRemoved += 1;
                }

            }
            return numberOfItemsRemoved;
        }

        public void RemoveAt(int index)
        {
            try
            {
                if (index.CompareTo(data.Length) == 1)
                {
                    throw new IndexOutOfRangeException("Index out of range - ");
                }

                data[index] = default(T);
                for (int i = index; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid index {0}", e.Message);
            }
        }

        public int indexOf(T item)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Capacity
        {
            get
            {
                return data.Length;

            }
            set
            {
                try
                {
                    if (value < Capacity)
                    {
                        throw new ArgumentOutOfRangeException("Value is less than Capacity - ");
                    }
                
                T[] newArray = new T[value];
                for (int i = 0; i < data.Length; i++)
                    {
                        newArray[i] = data[i];
                    }
                    data = newArray;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot resize array {0}", e.Message);
                }
            }
          
        }

        public int Count
        {
            get
            {
                int numberOfElements = 0;
                foreach(object i in data)
                {
                    int element = Convert.ToInt32(i);
                    if (element != 0)
                    {
                        numberOfElements++;
                    }
                }
                return numberOfElements;
            }
        }

        public T Max
        {
            get
            {
                T maxValue = data[0];
                for (int i = 1; i < data.Length; i++)
                {
                    if(data[i].CompareTo(maxValue) == 1)
                    {
                        maxValue = data[i];
                    }
                }
                return maxValue;
            }
        }

        public T Min
        {
            get
            {
                T minValue = data[0];
                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i].CompareTo(minValue) == -1)
                    {
                        minValue = data[i];
                    }
                }
                return minValue;
            }
        }


        public T this[int index]
        {
            get
            {
                return data[index]; 
            }
            set
            {
                data[index] = value;
            }
        }

		public override string ToString()
		{
            return string.Format("{0}", data);
		}
	}
}
