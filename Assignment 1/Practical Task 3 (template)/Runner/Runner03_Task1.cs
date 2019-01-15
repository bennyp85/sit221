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
            // manage the size of the problem here
            int problem_size = 10000; 
            // create a vector class variable
            Vector<int> vector = new Vector<int>(problem_size); 
            // this object measures time elapsed
            Stopwatch s = new Stopwatch(); 
            IntAscendingComparer ascendingComparer = new IntAscendingComparer();
            IntDescendingComparer descendingComparer = new IntDescendingComparer();


            // generate a sequence of integers for the problem and store them in a separate array
            int[] data = new int[problem_size]; 
            Random k = new Random(100);
            for (int i = 0; i < problem_size; i++) data[i]=k.Next(10000);

            // print out array
            //Console.WriteLine("Initial data:");
            //Console.WriteLine(data);

            // ------------------ Default Sort ----------------------------------
            Console.WriteLine("\n::We are running Default Sort");
            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            // this uploads integers to the vector every time before sorting
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]); 
            s.Restart();

            // !!!Sort the vector here in ascending order with Default Sort
            vector.Sort(ascendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // !!!Sort the vector here in descending order with Default Sort
            vector.Sort(descendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);


            // ------------------ BubbleSort ----------------------------------
            Console.WriteLine("\n::We are running BubbleSort");
            vector.Sorter = new BubbleSort(); // uncomment, change to BubbleSort

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in ascending order with BubbleSort
            vector.Sort(ascendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();
            // Sort the vector here in descending order with BubbleSort
            vector.Sort(descendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);


            // ------------------ SelectionSort ----------------------------------
            Console.WriteLine("\n::We are running SelectionSort");
            vector.Sorter = new SelectionSort(); // uncomment, change to SelectionSort

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in ascending order with SelectionSort
            vector.Sort(ascendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in descending order with SelectionSort
            vector.Sort(descendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);


            // ------------------ InsertionSort ----------------------------------
            Console.WriteLine("\n::We are running InsertionSort");
            vector.Sorter = new InsertionSort(); // uncomment, change to InsertionSort

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in ascending order with InsertionSort
            vector.Sort(ascendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);

            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in descending order with InsertionSort
            vector.Sort(descendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);


            // ------------------ RandomizedQuickSort ----------------------------------
            Console.WriteLine("\n::We are running RandomizedQuickSort");
            vector.Sorter = new RandomizedQuickSort(); // uncomment, change to RandomizedQuickSort

            Console.WriteLine("After sort in assending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in ascending order with RandomizedQuickSort
            vector.Sort(ascendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);
              
            Console.WriteLine("After sort in descending order:");
            vector.Clear();
            for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
            s.Restart();

            // Sort the vector here in descending order with RandomizedQuickSort
            vector.Sort(descendingComparer);
            s.Stop();
            Console.WriteLine("Sorting Time: " + s.ElapsedMilliseconds);
            Console.WriteLine(vector);

            vector.BinarySearch(4999);

            Console.ReadLine();

        }
	}
}