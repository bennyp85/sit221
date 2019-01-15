using DataStructures_Algorithms.Utils;
using DataStructures_Algorithms.Week01;
using System;

namespace Runner
{
    class Runner02_Task1 : IRunner
    {
        public void Run(string[] args)
        {
            //Note: args[0] is the input file name -- make sure to change it as needed, currently 1H.txt
            if (args.Length < 2)
            {
                Console.WriteLine("input and/or output file name(s) is(are) missing");
                return;
            }

            Vector<int> vector = null;

            string inputFileName = args[0];
            string outputFileName = args[1];
            DataSerializer<int>.LoadVectorFromTextFile(inputFileName, ref vector);

            if (vector == null)
            {
                Console.WriteLine("Failed to load data from input file");
                return;
            }

            // check the state of capacity and count properties
            Console.WriteLine("Vector Capacity is {0}", vector.Capacity);
            Console.WriteLine("Vector Count is {0}", vector.Count);

            Console.WriteLine(vector);

            vector.Sort();

            Console.WriteLine(vector);
            DataSerializer<int>.SaveVectorToTextFile(outputFileName, vector);
            Console.WriteLine(string.Format("Data has been stored to {0}", outputFileName));

            Console.Read();
        }
    }
}
