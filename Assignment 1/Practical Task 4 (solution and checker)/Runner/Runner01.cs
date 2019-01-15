using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Utils;
namespace Runner
{
    class Runner01 : IRunner
    {
        public void Run(string[] args)
        {
            Vector<int> v = null;
            try
            {
                v = new Vector<int>(50);
                v.Add(5); v.Add(2); v.Add(6); v.Add(8); v.Add(5); v.Add(5); v.Add(1); v.Add(8); v.Add(5); v.Add(3); v.Add(5);
                Console.WriteLine(v);
                Console.WriteLine(v.RemoveAll(5));
                Console.WriteLine(v);
                Console.WriteLine(v.Max());
                Console.WriteLine(v.Min());
                v.Insert(0, 5);
                Console.WriteLine(v);
                Console.WriteLine(v.Contains(5) ? "correct" : "INCORRECT");
                Console.WriteLine(v[0]);
                Console.WriteLine(v[v.Count - 1]);
                v.RemoveAt(0);
                v.RemoveAt(v.Count - 1);
                Console.WriteLine(v[0]);
                Console.WriteLine(v[v.Count - 1]);
                Console.WriteLine(v);
                Console.WriteLine(v.Remove(5) ? "INCORRECT" : "correct");
                Console.WriteLine(v.IndexOf(5));
                v.Clear();
                Console.WriteLine(v);
                Console.WriteLine(v.Max());
                Console.WriteLine(v.Min());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                v.RemoveAt(0);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("correct");
            }
            catch (Exception)
            {
                Console.WriteLine("INCORRECT");
            }

            try
            {
                Console.WriteLine(v[0]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("correct");
            }
            catch (Exception)
            {
                Console.WriteLine("INCORRECT");
            }

            try
            {
                v.Insert(1, 10);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("correct");
            }
            catch (Exception)
            {
                Console.WriteLine("INCORRECT");
            }

            try
            {
                v.Capacity = 0;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("correct");
            }
            catch (Exception)
            {
                Console.WriteLine("INCORRECT");
            }

        }
    }
}
