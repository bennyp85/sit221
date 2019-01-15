using DataStructures_Algorithms.Utils;
using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week03;
using System;
using System.Diagnostics;

namespace Runner
{
	public class Runner03_Task1 : IRunner
	{

		public void Run(string[] args)
		{

            int problem_size = 10000;
            Vector<int> vector = new Vector<int>(problem_size);
            Stopwatch s = new Stopwatch();


            int[] data = new int[problem_size];
            Random k = new Random(100);
            for (int i = 0; i < problem_size; i++) data[i]=k.Next(10000);

            //Console.WriteLine("Initial data:");
            //Console.WriteLine(data);

            // ------------------ Default Sort ----------------------------------
            Console.WriteLine("\n::We are running Default Sort");
            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntAscendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntDescendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);


            // ------------------ BubbleSort ----------------------------------
            Console.WriteLine("\n::We are running BubbleSort");
            vector.Sorter = new BubbleSort();

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntAscendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntDescendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);


            // ------------------ SelectionSort ----------------------------------
            Console.WriteLine("\n::We are running SelectionSort");
            vector.Sorter = new SelectionSort();

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntAscendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntDescendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);


            // ------------------ InsertionSort ----------------------------------
            Console.WriteLine("\n::We are running InsertionSort");
            vector.Sorter = new InsertionSort();

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntAscendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntDescendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);


            // ------------------ RandomizedQuickSort ----------------------------------
            Console.WriteLine("\n::We are running RandomizedQuickSort");
            vector.Sorter = new RandomizedQuickSort();

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntAscendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            vector.Sort(new IntDescendingComparer());
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            //Console.WriteLine(vector);

            vector.Sort(new IntAscendingComparer());
            Console.WriteLine(vector.BinarySearch(6));
            Console.WriteLine(vector.BinarySearch(9999));

            Console.ReadLine();
        }
	}
}