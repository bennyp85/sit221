using System;
using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week02;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class  Runner02_Task2 : IRunner 
    {
        public void Run(string[] args)
        {
            //create vector of parts
            Vector<Part> parts = new Vector<Part>();

            parts.Add(new Part() { PartName = "regular seat", PartId = 3 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 2 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 7 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 9 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 0 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 3 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 4 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 6 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 8 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 10 });

    
            // ToString method in the Part class.
            Console.WriteLine("\nBefore sort:");
            Console.WriteLine(parts);



            parts.Sort();
            Console.WriteLine("\nAfter sort by part number (Ascending):");
            Console.WriteLine(parts);


            PartComparer pc = new PartComparer();
            parts.Sort(pc);
            Console.WriteLine("\nAfter sort by part number (Descending):");
            Console.WriteLine(parts);

            Console.Read();
        }
    }
}