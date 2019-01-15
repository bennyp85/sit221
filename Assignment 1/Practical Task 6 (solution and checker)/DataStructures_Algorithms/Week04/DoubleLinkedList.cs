using DataStructures_Algorithms.Week04;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week04
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }

        public DoubleLinkedList() { }

        public Node<T> AddFirst(T value)
        {
            if (Count == 0) return AddToEmpty(value);
            else
            {
                Node<T> newNode = AddNode(value, null, First, this);
                First = newNode;
                return newNode;
            }
        }

        public void AddFirst(Node<T> newNode)
        {
            if (newNode == null) throw new ArgumentNullException("node is null");
            if (newNode.Owner!=null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (Count == 0) AddToEmpty(newNode);
            else
            {
                AddNode(newNode, null, First, this);
                First = newNode;
            }
        }

        public Node<T> AddLast(T value)
        {
            if (Count == 0) return AddToEmpty(value);
            else
            {
                Node<T> newNode = AddNode(value, Last, null, this);
                Last = newNode;
                return newNode;
            }
        }

        private Node<T> AddToEmpty(T value)
        {
            Node<T> newNode = AddNode(value, null, null, this);
            First = newNode;
            Last = newNode;
            return newNode;
        }

        private void AddToEmpty(Node<T> newNode)
        {
            AddNode(newNode, null, null, this);
            First = newNode;
            Last = newNode;
        }

        private Node<T> AddNode(T value, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        {
            Node<T> node = new Node<T>(value);
            AddNode(node, previous, next, owner);
            return node;
        }

        private void AddNode(Node<T> node, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        {
            node.Next = next;
            node.Previous = previous;
            node.Owner = owner;
            if (next != null) next.Previous = node;
            if (previous != null) previous.Next = node;
            Count++;
        }

        public void AddLast(Node<T> newNode)
        {
            if (newNode == null) throw new ArgumentNullException("node is null");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (Count == 0) AddToEmpty(newNode);
            else
            {
                AddNode(newNode, Last, null, this);
                Last = newNode;
            }
        }

        public Node<T> AddBefore(Node<T> node, T value)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (node.Equals(First)) return AddFirst(value);
            return AddNode(value, node.Previous, node, this);
        }

        public void AddBefore(Node<T> node, Node<T> newNode)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (newNode == null) throw new ArgumentNullException("new node is null");
            if(!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (node.Equals(First)) AddFirst(newNode);
            else AddNode(newNode, node.Previous, node, this);
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (node.Equals(Last)) return AddLast(value);
            return AddNode(value, node, node.Next, this);
        }

        public void AddAfter(Node<T> node, Node<T> newNode)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (newNode == null) throw new ArgumentNullException("new node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (node.Equals(Last)) AddLast(newNode);
            else AddNode(newNode, node, node.Next, this);
        }

        public void Clear()
        {
            while (First != null)
            {
                First.Owner = null;
                Node<T> temp = First;
                First = First.Next;
                temp = null;
            }
            Count = 0;
        }

        public Node<T> Find(T value)
        {
            Node<T> node = First;
            while (node != null)
            {
                if (node.Value.Equals(value)) return node;
                node = node.Next;
            }
            return null;
        }

        public Node<T> FindLast(T value)
        {
            Node<T> node = Last;
            while (node != null)
            {
                if (node.Value.Equals(value)) return node;
                node = node.Previous;
            }
            return null;
        }

        public bool Contains(T value)
        {
            if (Find(value) != null) return true;
            else return false;
        }

        public void Remove(Node<T> node)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (!node.Equals(First)) node.Previous.Next = node.Next;
            if (!node.Equals(Last)) node.Next.Previous = node.Previous;
            node.Owner = null;
            Count--;
        }

        public bool Remove(T value)
        {
            Node<T> node = Find(value);
            if (node == null) return false;
            Remove(node);
            return true;
        }

        public void RemoveFirst()
        {
            if (First==null) throw new InvalidOperationException("the DoubleLinkedList<T> is empty");
            Remove(First);
        }

        public void RemoveLast()
        {
            if (First == null) throw new InvalidOperationException("the DoubleLinkedList<T> is empty");
            Remove(Last);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            if (Count == 0) return "[]";
            StringBuilder s = new System.Text.StringBuilder();
            s.Append("[");
            int k = 0;
            foreach (T element in this)
            {
                s.Append(element.ToString());
                if (k < Count - 1) s.Append(",");
                k++;
            }
            s.Append("]");
            return s.ToString();
        }

    }
}
