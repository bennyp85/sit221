using DataStructures_Algorithms.Week04;
using System;
using System.Collections.Generic;

namespace Runner
{
    class Runner04_Task1 : IRunner
    {
        public void Run(string[] args)
        {
            DoubleLinkedList<int> l = null;
            try
            {
                Node<int> node = null;
                l = new DoubleLinkedList<int>();

                Console.WriteLine(l);
                l.Clear(); Console.WriteLine(l);

                l.AddLast(100); Console.WriteLine(l);
                l.AddFirst(30); Console.WriteLine(l);
                l.AddBefore(l.Last,70); Console.WriteLine(l);
                l.AddBefore(l.First, 15); Console.WriteLine(l);
                l.AddAfter(l.First, 20); Console.WriteLine(l);
                l.AddAfter(l.Last, 150); Console.WriteLine(l);

                node = l.Find(80); Console.WriteLine(node);
                node = l.Find(30); Console.WriteLine(node);
                node.Value = 6;
                //node.Owner = null;
                l.Remove(node); Console.WriteLine(node); Console.WriteLine(l);
                l.AddAfter(l.First,node); Console.WriteLine(node); Console.WriteLine(l);

                l.Remove(100); Console.WriteLine(l);
                l.Clear(); Console.WriteLine(l);
                l.AddFirst(node); Console.WriteLine(l);
                node = l.Find(30); Console.WriteLine(node);

                try
                {
                    l.AddFirst(node);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("correct");
                }
                finally { Console.WriteLine(l); }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

}
