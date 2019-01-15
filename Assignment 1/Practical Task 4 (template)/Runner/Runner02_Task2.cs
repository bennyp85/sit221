using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Runner02_Task2 : IRunner
    {
        public void Run(string[] args)
        {
            //create vector of parts
            Vector<Part> parts = new Vector<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;

            // Name intentionally left null.
            parts.Add(new Part() { PartId = 1334 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });

            // ToString method in the Part class.
            Console.WriteLine("\nBefore sort:");
            Console.WriteLine(parts);

            parts.Sort();
            Console.WriteLine("\nAfter sort by part number (Ascending):");
            Console.WriteLine(parts);

            parts.Sort(new PartComparer());
            Console.WriteLine("\nAfter sort by part number (Descending):");
            Console.WriteLine(parts);

            Console.Read();
        }
    }
}