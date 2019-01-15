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

        // we use this to add a new node, that has been already created and now is passed by reference via Node<T> node
        // we also pass its Node<T> previous, Node<T> next, DoubleLinkedList<T> owner
        private void AddNode(Node<T> node, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        {
            node.Next = next;
            node.Previous = previous;
            node.Owner = owner;
            if (next != null) next.Previous = node; // this is for the case when we add a new node and it is not to be the last one; we make the previous node referring to the new node
            if (previous != null) previous.Next = node; // this is for the case when we add a new node and it is not to be the first one; we make the next node referring to the new node
            Count++;
        }

        // we use this to create a new node first when we are provided a new value T value;
        // we then delegate adding the new node to the previous function AddNode(Node<T> node, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        // we therefore reuse the code of AddNode(Node<T> node, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        private Node<T> AddNode(T value, Node<T> previous, Node<T> next, DoubleLinkedList<T> owner)
        {
            Node<T> node = new Node<T>(value);
            AddNode(node, previous, next, owner);
            return node;
        }

        // we call this function when provided with the (T value) of a new node and the Linked List is empty
        private Node<T> AddToEmpty(T value)
        {
            Node<T> newNode = AddNode(value, null, null, this);
            First = newNode;
            Last = newNode;
            return newNode;
        }

        // we call this function when provided with the existing (Node<T> newNode) and the Linked List is empty
        private void AddToEmpty(Node<T> newNode)
        {
            AddNode(newNode, null, null, this);
            First = newNode;
            Last = newNode;
        }

        public Node<T> AddFirst(T value)
        {
            if (Count == 0) return AddToEmpty(value); // we first check whether the list is empty
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
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (Count == 0) AddToEmpty(newNode); // we first check whether the list is empty
            else
            {
                AddNode(newNode, null, First, this);
                First = newNode;
            }
        }

        public Node<T> AddLast(T value)
        {
            if (Count == 0) return AddToEmpty(value); // we first check whether the list is empty
            else
            {
                Node<T> newNode = AddNode(value, Last, null, this);
                Last = newNode;
                return newNode;
            }
        }

        public void AddLast(Node<T> newNode)
        {
            if (newNode == null) throw new ArgumentNullException("node is null");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (Count == 0) AddToEmpty(newNode); // we first check whether the list is empty
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
            if (node.Equals(First)) return AddFirst(value); // we first check whether we are actually adding the value as the first node of the Linked List
            return AddNode(value, node.Previous, node, this);
        }

        public void AddBefore(Node<T> node, Node<T> newNode)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (newNode == null) throw new ArgumentNullException("new node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (node.Equals(First)) AddFirst(newNode); // we first check whether we are actually adding the value as the first node of the Linked List
            else AddNode(newNode, node.Previous, node, this);
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (node.Equals(Last)) return AddLast(value); // we first check whether we are actually adding the value as the last node of the Linked List
            return AddNode(value, node, node.Next, this);
        }

        public void AddAfter(Node<T> node, Node<T> newNode)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (newNode == null) throw new ArgumentNullException("new node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (newNode.Owner != null) throw new InvalidOperationException("node already belongs to (another) DoubleLinkedList<T>");
            if (node.Equals(Last)) AddLast(newNode); // we first check whether we are actually adding the value as the last node of the Linked List
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
            while (node != null) // we iterate through the nodes untill the pointer (i.e. the current Node<T> node) is equal to null, thus the end of the List is met
            {
                if (node.Value.Equals(value)) return node;
                node = node.Next;
            }
            return null;
        }

        public Node<T> FindLast(T value)
        {
            Node<T> node = Last;
            while (node != null) // we iterate through the nodes untill the pointer (i.e. the current Node<T> node) is equal to null, thus the end of the List is met
            {
                if (node.Value.Equals(value)) return node;
                node = node.Previous;
            }
            return null;
        }

        public bool Contains(T value)
        {
            // if it cannot be found, then it does not exist
            if (Find(value) != null) return true;
            else return false;
        }

        public void Remove(Node<T> node)
        {
            if (node == null) throw new ArgumentNullException("node is null");
            if (!Equals(node.Owner)) throw new InvalidOperationException("node is not in the current DoubleLinkedList<T>");
            if (!node.Equals(First)) node.Previous.Next = node.Next;
            else First = node.Next;
            if (!node.Equals(Last)) node.Next.Previous = node.Previous;
            else Last = node.Previous;
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
            if (First == null) throw new InvalidOperationException("the DoubleLinkedList<T> is empty");
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