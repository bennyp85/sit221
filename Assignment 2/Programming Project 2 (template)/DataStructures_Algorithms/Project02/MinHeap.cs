using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project02
{
	public class MinHeap<D, K> where K : IComparable<K>
	{
		private List<Node<D,K>> heap;

        /// <summary>
        /// Gets the number of elements contained in the MinHeap
        /// </summary>
        /// <value>The count.</value>
		public int Count { get; set; }

		private IComparer<IHeapifyable<D,K>> Comparer;


        /// <summary>
        /// Initializes a new instance of the MinHeap
        /// </summary>
        /// <param name="comparer">Comparer.</param>
		public MinHeap(IComparer<IHeapifyable<D, K>> comparer)
		{
			heap = new List<Node<D,K>>();
			this.Comparer = comparer!=null? comparer:new DefaultComparer<D,K>();
			heap.Add(default(Node<D,K>));
			heap[0] = null;

		}

		private class DefaultComparer<D,K> : IComparer<IHeapifyable<D, K>>
		{
			public int Compare(IHeapifyable<D, K> x, IHeapifyable<D, K> y)
			{
				return Comparer<K>.Default.Compare(x.Key, y.Key);
			}
		}

		internal class Node<D,K> : IHeapifyable<D, K>
		{
			public D Data { get; set; }
			public K Key { get; set; }
			public int Position { get; set; }

			public Node(D data, K key, int position)
			{
				Data = data;
				Key = key;
				Position = position;
			}
		}

        //methods to get index of child or parent
		int getLeftChildIndex(int parentIndex) { return 2 * parentIndex ; }
		int getRightChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
		int getParentIndex(int childIndex) { return (childIndex) / 2; }

		
        /// <summary>
        /// Adds a new node containing the specified key‐value pair to the MinHeap
        /// </summary>
        /// <returns>The heap.</returns>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
		public IHeapifyable<D, K> Insert(K key, D value)
		{
			heap.Add(new Node<D,K>(value, key, Count + 1));
			Count++;
			UpHeap(Count);
			return heap[Count];
		}

		private void UpHeap(int index)
		{
			int parentIndex;
			if (index !=0)
			{
				parentIndex = getParentIndex(index);
				if (parentIndex <= 0)
					return;
                //compare the current value to its parent
				if (Comparer.Compare(heap[parentIndex], heap[index]) > 0)
				{
					Node<D,K> tmp = heap[parentIndex];
					heap[parentIndex] = heap[index];
					heap[index] = tmp;
					heap[index].Position = index;
					heap[parentIndex].Position = parentIndex;
                    //recursively calls UpHeap()
					UpHeap(parentIndex);
				}
			}
		}


         /// <summary>
         /// Returns the element yielding the minimum key
         /// </summary>
         /// <returns>The Heap minimum.</returns>
        ///<exception cref="InvalidOperationException">Thrown when heap is empty</exception>
		public IHeapifyable<D, K> Min()
		{
			if (Count == 0) throw new InvalidOperationException();
			//return root node
			return heap[1];
		}


        /// <summary>
        /// Removes and returns the element yielding the minimum key
        /// </summary>
        /// <returns>The minimum node in the heap</returns>
        /// <exception cref="InvalidOperationException">Thrown when heap is empty</exception>
		public IHeapifyable<D, K> DeleteMin()
		{
			if (Count == 0) throw new InvalidOperationException("Heap Empty");
			else
			{
				Node<D,K> tmp = heap[1];
				heap[1] = heap[Count];
				heap[1].Position = 1;
				heap[Count] = tmp;
				heap.RemoveAt(Count);
				Count--;
				DownHeap(1);
				return tmp;
			}

		}

		private void DownHeap(int index)
		{
			int leftChildIndex, rightChildIndex;
			leftChildIndex = getLeftChildIndex(index);
			rightChildIndex = getRightChildIndex(index);

			if (index >= Count)
				return;
			int myVar = index;
            //compare the current value to its children
			if (leftChildIndex <= Count && Comparer.Compare(heap[leftChildIndex], heap[index]) < 0 )
				myVar = leftChildIndex;
			if (rightChildIndex <= Count && Comparer.Compare(heap[rightChildIndex], heap[myVar]) < 0)
				myVar = rightChildIndex;
			if (myVar != index)
			{
				Node<D,K> tmp = heap[index];
				heap[index] = heap[myVar];
				heap[myVar] = tmp;
				heap[index].Position = index;
				heap[myVar].Position = myVar;
                //recursively calls DownHeap()
				DownHeap(myVar);
			}
		}

		public void Clear()
		{
			heap.Clear();
			heap.Add(null);
			Count = 0;
		}

		public bool IsEmpty()
		{
			return Count == 0;
		}


        /// <summary>
        /// Builds a minimum binary heap using the specified keys and data according to the bottom‐up approach
        /// </summary>
        /// <returns>The heap.</returns>
        /// <param name="keys">Keys.</param>
        /// <param name="data">Data.</param>
        /// <exception cref="InvalidOperationException">Thrown when heap is not empty</exception>
		public IHeapifyable<D, K>[] BuildHeap(K[] keys, D[] data)
		{
			if (Count == 0)
				Clear();
            //checks if heap is empty
			if (!IsEmpty())
				throw new InvalidOperationException("Heap is not empty...");
			for (int i = 0; i < keys.Length; i++)
				Insert(keys[i], data[i]);
			IHeapifyable<D, K>[] array = new IHeapifyable<D, K>[Count];
			for (int i = 0; i < Count; i++)
				array[i] = heap[i + 1];
			return array;


		}


        /// <summary>
        /// Decreases the key of the specified element presented in the current heap
        /// </summary>
        /// <param name="element">Element.</param>
        /// <param name="new_key">New key.</param>
        /// <exception cref="InvalidOperationException">Thrown if the element stored in the heap in the specific position is different to that node</exception>
		public void DecreaseKey(IHeapifyable<D, K> element, K new_key)
		{
            //checks if specified element in MinHeap is different to node
			if (Comparer.Compare(heap[element.Position], element) != 0)
				throw new InvalidOperationException("Invalid Element");
			heap[element.Position].Key = new_key;
			int i = element.Position;
			while (i != 1 && Comparer.Compare(heap[i / 2], heap[i]) == 0)
			{
				Node<D, K> tmp = heap[i];
				heap[i] = heap[i * 2];
				heap[i * 2] = tmp;
				i = i / 2;

			}

		}

		public override string ToString()
		{
			string str = "";
			str += "[";
			for (int i = 1; i <= Count; i++)
			{
				str = str + "(" + heap[i].Key + "," + heap[i].Data + "," + heap[i].Position+")" ;
				if (i != Count)
					str = str + ",";
			}
			return str+"]";
		}
	}
}
