using Runner.Data.Project01;
using DataStructures_Algorithms.Project01;
using System.Linq;
using System;

namespace Runner
{
    public class RunnerPr01_02
    {

        public void Run(string[] args)
        {
            
            for (int i=0; i< SortingOrder_Generator.Count(); i++)
            {
                SortingOrder order = new SortingOrder();
                string[] a1 = null;
                int[] a2 = null;
                int[] a3 = null;
                string result = SortingOrder_Generator.Generate(i, out a1, out a2, out a3);
                Console.WriteLine("Test {0}: {1}\tcorrect result is {2}", i, result == order.Solve(a1, a2, a3), result);
                //Console.WriteLine("Test {0}: {1}\tcorrect result is {2}", i, order.Solve(a1, a2, a3), result);
            }
            Console.ReadLine();
        }
    }

    	


}
