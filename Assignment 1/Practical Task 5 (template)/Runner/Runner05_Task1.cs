using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week05;
using System;
using System.Collections.Generic;

namespace Runner
{
    class Runner05_Task1 : IRunner
    {
        public void Run(string[] args)
        {
            // The code below tests MyStack implementation
            // TODO: uncomment these lines when the MyStack<int> is ready
            //MyStack<int> l = null;
            //try
            //{
            //    l = new MyStack<int>();

            //    Console.WriteLine(l);
            //    l.Clear(); Console.WriteLine(l);
            //    l.Push(5); l.Push(10); l.Push(15); l.Push(20); l.Push(25); Console.WriteLine(l);
            //    Console.WriteLine("Peek() -> {0}",l.Peek()); Console.WriteLine(l);
            //    Console.WriteLine("Pop() -> {0}", l.Pop()); Console.WriteLine(l);
            //    l.Push(9);
            //    Console.WriteLine("Count: {0}", l.Count); Console.WriteLine(l);
            //    Console.WriteLine("Contains 0: {0}", l.Contains(0));
            //    Console.WriteLine("Contains 0: {0}", l.Contains(15));
            //    try
            //    {
            //        for (int i = 0; i < 6; i++)
            //        {
            //            Console.WriteLine("Pop() -> {0}", l.Pop()); Console.WriteLine(l);
            //        }
            //    }
            //    catch (InvalidOperationException)
            //    {
            //        Console.WriteLine("correct");
            //    }
            //    finally { Console.WriteLine(l); }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //// The code below tests implementation of RPNCalculator
            //Vector<string> expression = new Vector<string>();

            //expression.Add("4");
            //expression.Add("5");
            //expression.Add("3");
            //expression.Add("*");
            //expression.Add("+");
            //expression.Add("6");
            //expression.Add("2");
            //expression.Add("/");
            //expression.Add("-");
            //RPNCalculator calc = new RPNCalculator(expression);
            //Console.WriteLine(string.Format("Input Expression = {0}, and the result = {1}", expression.ToString(), calc.GetResult()));

            Console.ReadLine();
        }
    }

}
