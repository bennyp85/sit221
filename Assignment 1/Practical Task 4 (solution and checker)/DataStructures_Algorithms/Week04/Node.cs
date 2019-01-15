using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week04
{

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; internal set; }
        public Node<T> Previous { get; internal set; }
        public DoubleLinkedList<T> Owner { get; internal set; }

        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.Append("{");
            s.Append(Previous == null ? "x" : Previous.Value.ToString());
            s.Append("-(");
            s.Append(Value);
            s.Append(")-");
            s.Append(Next == null ? "x" : Next.Value.ToString());
            s.Append("}");
            return s.ToString();
        }

    }
}