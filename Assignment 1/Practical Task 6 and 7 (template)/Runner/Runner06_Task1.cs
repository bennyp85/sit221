using DataStructures_Algorithms.Week04;
using DataStructures_Algorithms.Week06;
using DataStructures_Algorithms.Week08;
using System;

namespace Runner
{
    class Runner06_Task1 : IRunner
    {
        public void Run(string[] args)
        {
                BinarySearchTree<string> BST = null;
                try
                {
                    BST = new BinarySearchTree<string>();

                    int count = 0, min = int.MaxValue, max = int.MinValue;

                    Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
                    Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == int.MaxValue? "correct" : "incorrect");
                    Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == int.MinValue  ? "correct" : "incorrect");

                    int key = 100; string value = "John";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 50; value = "Michael";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 150; value = "Linda";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 75; value = "Thomas";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 25; value = "Karl";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 10; value = "Zoya";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 5; value = "Peter";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 60; value = "Frank";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    key = 80; value = "Ben";
                    BST.Add(key, value);
                    count++; min = Math.Min(min, key); max = Math.Max(max, key);
                    if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
                    else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

                    Console.WriteLine("Checking BST.Count: {0}", BST.Count==count ? "correct" : "incorrect");
                    Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == min ? "correct" : "incorrect");
                    Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

                    Console.Write("Checking BST.Traverse(TraversalMode.PRE)):\t");
                    foreach (string v in BST.Traverse(TraversalMode.PRE)) Console.Write("{0} ", v);
                    Console.WriteLine();
                    Console.Write("Checking BST.Traverse(TraversalMode.IN)):\t");
                    foreach (string v in BST.Traverse(TraversalMode.IN)) Console.Write("{0} ", v);
                    Console.WriteLine();
                    Console.Write("Checking BST.Traverse(TraversalMode.POST)):\t");
                    foreach (string v in BST.Traverse(TraversalMode.POST)) Console.Write("{0} ", v);
                    Console.WriteLine();

            //        // Testing remove operation : Here Practical Task 7 starts.
            //        key = 5; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey != min ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

            //        key = 5; value = "Gilbert";
            //        BST.Add(key, value);
            //        count++; min = Math.Min(min, key); max = Math.Max(max, key);
            //        if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
            //        else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == min ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

            //        key = 10; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == min ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

            //        key = 500; value = "Anna";
            //        BST.Add(key, value);
            //        count++; min = Math.Min(min, key); max = Math.Max(max, key);
            //        if (BST.Contains(key)) Console.WriteLine("BST now contains:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? value : "WRONG RESULT");
            //        else Console.WriteLine("PROBLEM: BST must contain:\tkey = {0}   \tvalue = {1}", key, value);

            //        key = 150; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        key = 100; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == min ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

            //        key = 80; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == min ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == max ? "correct" : "incorrect");

            //        key = 75; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        key = 60; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        key = 500; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        key = 50; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        key = 5; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == 25 ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == 25 ? "correct" : "incorrect");

            //        Console.WriteLine("Deletion unexisting BST: {0}", !BST.Remove(key) ? "correct" : "incorrect");

            //        key = 25; value = BST.Find(key);
            //        if (BST.Contains(key))
            //        {
            //            BST.Remove(key);
            //            count--;
            //            if (BST.Contains(key)) Console.WriteLine("PROBLEM: BST must NOT contain:\tkey = {0}   \tvalue = {1}", key, value);
            //            else Console.WriteLine("BST does not contain:\tkey = {0}   \tvalue = {1}", key, value.Equals(BST.Find(key)) ? "WRONG RESULT" : value);
            //        }

            //        Console.WriteLine("Checking BST.Count: {0}", BST.Count == count ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MinKey: {0}", BST.MinKey == int.MaxValue ? "correct" : "incorrect");
            //        Console.WriteLine("Checking BST.MaxKey: {0}", BST.MaxKey == int.MinValue ? "correct" : "incorrect");

            //        Console.WriteLine("Deletion from empty BST: {0}", !BST.Remove(key) ? "correct" : "incorrect");

            //        Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

        }
    }

}
