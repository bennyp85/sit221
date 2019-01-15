using DataStructures_Algorithms.Project02;
using Runner.Data.Project02;
using System;
using System.Collections.Generic;

namespace Runner
{
    public class Teleportation_Test
    {

        public void Run(string[] args)
        {
            
            for (int i=0; i< Teleportation_Generator.Count(); i++)
            {

                long a1, a2, a3, a4;
                long[] a5 = null, a6 = null, a7 = null;
                long result = Teleportation_Generator.Generate(i, out a1, out a2, out a3, out a4, out a5, out a6, out a7);
                //Teleportation teleport = new Teleportation();
                //long answer = teleport.Solve(a1, a2, a3, a4, a5, a6, a7);
                //Console.WriteLine("Test {0}: {1}\tcorrect result {2}     \tyour result {3}", i, result == answer, result, answer);
            }
            Console.ReadLine();
        }
    }

    	


}
