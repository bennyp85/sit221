using System;
using System.Collections.Generic;
using System.Linq;

namespace Runner
{
    public class HeapSort_Test
    {
        private static Random random = new Random(100);

        public void Run(string[] args)
        {
            int n = 20;
            int[] rawnums = new int[n];
            for (int i = n; i > 0; i--) rawnums[n - i] = 1000+random.Next(9000);

            //int[] data = new List<int>(rawnums).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", data));
            //(new HeapSort()).Sort(data, null);
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", data));

            //data = new List<int>(rawnums).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", data));
            //(new HeapSort()).Sort(data, new IntAscendingComparer());
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", data));


            //data = new List<int>(rawnums).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", data));
            //(new HeapSort()).Sort(data, new IntDescendingComparer());
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", data));

            //string[] rawstrings = new string[n];
            //for (int i = n; i > 0; i--) rawstrings[n - i] = RandomString(3);

            ////rawstrings = new string[2] { "WD2", "W4M"};
            //string[] stringdata = new List<string>(rawstrings).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", stringdata));
            //(new HeapSort()).Sort(stringdata, null);
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", stringdata));

            //stringdata = new List<string>(rawstrings).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", stringdata));
            //(new HeapSort()).Sort(stringdata, new StringAscendingComparer());
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", stringdata));

            //stringdata = new List<string>(rawstrings).ToArray();
            //Console.WriteLine("Unsorted data :: [{0}]", string.Join(",", stringdata));
            //(new HeapSort()).Sort(stringdata, new StringDescendingComparer());
            //Console.WriteLine("Sorted data :: [{0}]", string.Join(",", stringdata));

            Console.ReadLine();
        }

        private class IntAscendingComparer : IComparer<int>
        {
            public int Compare(int A, int B)
            {
                return Math.Sign(A - B);
            }
        }

        private class IntDescendingComparer : IComparer<int>
        {
            public int Compare(int A, int B)
            {
                return -1 * Math.Sign(A - B);
            }
        }

        private class StringAscendingComparer : IComparer<string>
        {
            public int Compare(string A, string B)
            {
                return String.Compare(A, B);
            }
        }

        private class StringDescendingComparer : IComparer<string>
        {
            public int Compare(string A, string B)
            {
                return -1 * String.Compare(A, B);
            }
        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}
