/*********************************************************************************************************************************
*    Title: Reference Source .NET Framework 4.7.2
*    Author: Microsoft
*    Date: 7/8/18
*    Availability: https://referencesource.microsoft.com/#System/compmod/system/collections/generic/linkedlist.cs,3ffabc1cf5198ad1    
*********************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week04
{
    public class Node<T>
    {
        public Node<T> next;
        public Node<T> prev;
        internal T item;

        public Node(T item, Node<T> p, Node<T> n)
        {
            this.item = item;
            prev = p;
            next = n;

        }

        public Node(T value)
        {
            Node<T> node = new Node<T>(value);
        }

        public T Value { get; set; }

        public Node<T> Owner {get;}

        public Node<T> Next { get; internal set; }

        public Node<T> Previous { get; internal set; }

        public override string ToString()
        {
            return this.ToString();
        }

    }
}
