using DataStructures_Algorithms.Utils;
using DataStructures_Algorithms.Week01;
using System;

namespace Runner
{
    class  Runner02_Task1 : IRunner 
    {
        public void Run(string[] args)
        {
            //Note: args[0] is the input file name -- make sure to change it as needed, currently 1H.txt
            if (args.Length < 1)
            {
                Console.WriteLine("input file name is missing");
                return;
            }

            Vector<int> vector = null;

            string inputFileName = args[0];
            string outputFileName = "../../Data/Week01/1Hsorted.txt";
            DataSerializer<int>.LoadVectorFromTextFile(inputFileName, ref vector);

            if (vector == null)
            {
                Console.WriteLine("Failed to load data from input file");
                return;
            }

            // check the state of capacity and count properties
            Console.WriteLine("Vector Capacity is {0}", vector.Capacity);
            Console.WriteLine("Vector Count is {0}", vector.Count);

            // Call the sort method for the vector class here. This should follow the implementation part of task 1.1
            // The data should be sorted in ascending order
            vector.Sort();
            Console.WriteLine("Data has been sorted");
            DataSerializer<int>.SaveVectorToTextFile(outputFileName, vector);
            Console.WriteLine( string.Format("Data has been stored to {0}", outputFileName));

            Console.Read();
        }
    }
}
