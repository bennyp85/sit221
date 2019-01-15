using System;
using System.Collections.Generic;
using DataStructures_Algorithms.Project02;

namespace Runner
{
    public class MinHeap_Test
    {

        public void Run(string[] args)
        {
            int n = 9;
            int[] data = new int[n];
            long[] keys = new long[n];
            Random random = new Random(100);
            for (int i = n; i > 0; i--)
            {
                data[n - i] = 1000+random.Next(9000);
                keys[n - i] = i;
            }

            IHeapifyable<int, long> node = null;
            MinHeap<int, long> heap = new MinHeap<int, long>(null);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Performing: heap.Insert({0},{1}) :: key value is {0} and data value is {1}", keys[i], data[i]);
                heap.Insert(keys[i], data[i]);
                Console.WriteLine("Heap: {0}\n", heap);
            }

            while (!heap.IsEmpty())
            {
                node = heap.DeleteMin();
                Console.WriteLine("Performing: heap.DeleteMin() :: key-data pair of the deleted element is ({0},{1})", node.Key, node.Data);
                Console.WriteLine("Heap: {0}\n", heap);
            }

            Console.WriteLine("Performing:heap.BuildHeap(keys, data) :: key values are [{0}] and data values are [{1}]", string.Join(",", keys), string.Join(",", data));
            IHeapifyable <int,long>[] nodes = heap.BuildHeap(keys, data);
            Console.WriteLine("Heap: {0}\n", heap);

           // node = heap.DeleteMin();
            Console.WriteLine("Performing: heap.DeleteMin() :: key-data pair of the deleted element is ({0},{1})", node.Key, node.Data);
            Console.WriteLine("Heap: {0}\n", heap);

            nodes[0].Data = 0;
            Console.WriteLine("Performing value change:: for the element with key {0} new data value is {1}", nodes[0].Key, nodes[0].Data);
            nodes[7].Data = 777;
            Console.WriteLine("Performing value change:: for the element with key {0} new data value is {1}", nodes[7].Key, nodes[7].Data);
            nodes[8].Data = -1;
            Console.WriteLine("Performing value change:: for the element with key {0} new data value is {1} (not in the heap anymore)", nodes[8].Key, nodes[8].Data);
            Console.WriteLine("Heap: {0}\n", heap);

            Console.WriteLine("Performing key decreasing:: for the element with key {0} new key value must be {1}", nodes[0].Key, 0);
            heap.DecreaseKey(nodes[0],0);
            Console.WriteLine("Heap: {0}\n", heap);

            Console.ReadLine();
        }
    }




}
