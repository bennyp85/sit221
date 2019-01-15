/*********************************************************************************************************************************
*    Title: Reference Source .NET Framework 4.7.2
*    Author: Microsoft
*    Date: 7/8/18
*    Availability: https://referencesource.microsoft.com/#System/compmod/system/collections/generic/linkedlist.cs,3ffabc1cf5198ad1    
*********************************************************************************************************************************/

using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week04
{
    public class DoubleLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        internal int size;

        public bool isEmpty()
        {
            return size == 0;
        }

        public DoubleLinkedList()
        {
            head = new Node<T>(default(T), null, null);
            tail = new Node<T>(default(T), head, null);
            head.Next = tail;

        }

        public Node<T> Count { get; internal set; }

        public Node<T> First { get; internal set; }

        public Node<T> Last { get; internal set; }

        public Node<T> AddFirst(T value)
        {
            Node<T> node = new Node<T>(value, head, head.Next);
            head.Next = node;
            (head.Next).Previous = node;
            size++;
            return node;
        }

        public void AddFirst(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            head.Next = node;
            (head.Next).Previous = node;
            size++;
        }

        public Node<T> AddLast(T value)
        {
            Node<T> node = new Node<T>(value, tail.Previous, tail);
            (tail.Previous).Next = node;
            tail.Previous = node;
            size++;
            return node;
        }

        public void AddLast(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            (tail.Previous).Next = node;
            tail.Previous = node;
            size++;
            size++;
        }

        public Node<T> AddBefore(Node<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            Node<T> newNode = new Node<T>(value, head, tail);
            newNode.Next = node;
            newNode.Previous = node.Previous;
            (node.Previous).next = newNode;
            node.Previous = newNode;
            size++;
            return node;
        }

        public void AddBefore(Node<T> node, Node<T> newNode)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            newNode.Next = node;
            newNode.Previous = node.Previous;
            (node.Previous).next = newNode;
            node.Previous = newNode;
            size++;
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            Node<T> newNode = new Node<T>(value, head, tail);
            newNode.Previous = node;
            newNode.Next = node.Next;
            (node.Next).Previous = newNode;
            node.Next = newNode;
            size++;
            return node;

        }

        public void AddAfter(Node<T> node, Node<T> newNode)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            newNode.Previous = node;
            newNode.Next = node.Next;
            (node.Next).Previous = newNode;
            node.Next = newNode;
            size++;
        }

        public void Clear()
        {
            Node<T> current = head;
            while (current != null)
            {
                Node<T> temp = current;
                current = current.Next;
            }
            head = null;
            size = 0;
        }

        public Node<T> Find(T value)
        {
            Node<T> node = head;
            EqualityComparer<T> c = EqualityComparer<T>.Default; 

            if (node != null) {
                if (value != null) {
                    do {
                        if (c.Equals(node.item, value)) {
                            return node;   
                        }
                        node = node.next;
                    } while (node != head);
                } 
                else {
                    do {
                        if (node.item == null) {
                            return node;
                        }
                        node = node.next;
                    } while (node != head);
                }
            }
            return null;   
        }

        public Node<T> FindLast(T value)
        {
            if (head == null) return null;

            Node<T> last = head.prev;
            Node<T> node = last;
            EqualityComparer<T> c = EqualityComparer<T>.Default;
            if (node != null)
            {
                if (value != null)
                {
                    do
                    {
                        if (c.Equals(node.item, value))
                        {
                            return node;
                        }

                        node = node.prev;
                    } while (node != last);
                }
                else
                {
                    do
                    {
                        if (node.item == null)
                        {
                            return node;
                        }
                        node = node.prev;
                    } while (node != last);
                }
            }
            return null;
        }

        public bool Contains(T value)
        {
            return Find(value) != null;
        }

        public void Remove(Node<T> node)
        {
            Node<T> predecessor = node.Previous;
            Node<T> successor = node.Next;
            predecessor.Next = successor;
            successor.Previous = predecessor;
            size--;
        }

        public bool Remove(T value)
        {
            Node<T> node = Find(value);
            if (node != null)
            {
                node.next.prev = node.prev;
                node.prev.next = node.next;
                if (head == node)
                {
                    head = node.next;
                }
                size--;
                return true;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Empty List");
            }
            Remove(head.Next);
        }

        public void RemoveLast()
        {
            if(tail == null)
            {
                throw new InvalidOperationException("Empty List");
            }

            Remove(tail.Previous);
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
  
}
