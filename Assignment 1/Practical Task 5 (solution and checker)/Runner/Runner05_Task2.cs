using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week05;
using System;
using System.Collections.Generic;

namespace Runner
{
    class Runner05_Task2 : IRunner
    {
        public void Run(string[] args)
        {
            // The code below tests MyStack implementation
            MyQueue<int> l = null;
            try
            {
                l = new MyQueue<int>();

                Console.WriteLine(l);
                l.Clear(); Console.WriteLine(l);
                l.Enqueue(5); l.Enqueue(10); l.Enqueue(15); l.Enqueue(20); l.Enqueue(25); Console.WriteLine(l);
                Console.WriteLine("Peek() -> {0}",l.Peek()); Console.WriteLine(l);
                Console.WriteLine("Pop() -> {0}", l.Dequeue()); Console.WriteLine(l);
                l.Enqueue(9);
                Console.WriteLine("Count: {0}", l.Count); Console.WriteLine(l);
                Console.WriteLine("Contains 0: {0}", l.Contains(0));
                Console.WriteLine("Contains 0: {0}", l.Contains(15));
                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("Pop() -> {0}", l.Dequeue()); Console.WriteLine(l);
                    }
                }
                catch (InvalidOperationException)
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
