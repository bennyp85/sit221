using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week08
{
    public partial class Graph<T, K>
    {
        private LinkedList<Node> nodes = new LinkedList<Node>();

        public int NumVertices { get; private set; }
        public int NumEdges { get; private set; }

        public Graph() { }

        public INode<T> AddNode(T data)
        {
            Node node = new Node(data);
            node.ListNode = nodes.AddLast(node);
            NumVertices++;
            return node;
        }

        public IEdge<T, K> AddEdge(INode<T> from, INode<T> to, K data)
        {
            if (Contains(from, to)) return null;
            Node _from = (Node)from;
            Node _to = (Node)to;
            Edge edge = new Edge(_from, _to, data);
            _from.AddOutgoingEdge(edge);
            _to.AddIngoingEdge(edge);
            NumEdges++;
            return edge;
        }

        public void DeleteNode(INode<T> node)
        {
            Node _node = (Node)node;
            foreach (Edge edge in _node.GetIngoingEdges())
            {
                _node.DeleteIngoingEdge(edge);
                ((Node)edge.From).DeleteOutgoingEdge(edge);
                NumEdges--;
            }
            foreach (Edge edge in _node.GetOutgoingEdges())
            {
                _node.DeleteOutgoingEdge(edge);
                ((Node)edge.To).DeleteIngoingEdge(edge);
                NumEdges--;
            }
            nodes.Remove(_node.ListNode);
            NumVertices--;
        }

        public void DeleteEdge(INode<T> from, INode<T> to)
        {
            Node _from = (Node)from;
            Node _to = (Node)to;
            Edge edge = _from.Find(_to);
            _from.DeleteOutgoingEdge(edge);
            _to.DeleteIngoingEdge(edge);
            NumEdges--;
        }

        public void DeleteEdge(IEdge<T, K> edge)
        {
            Node _from = (Node)edge.From;
            Node _to = (Node)edge.To;
            _from.DeleteOutgoingEdge((Edge)edge);
            _to.DeleteIngoingEdge((Edge)edge);
            NumEdges--;
        }

        public IEdge<T, K> Find(INode<T> from, INode<T> to)
        {
            Node _from = (Node)from;
            Node _to = (Node)to;
            return _from.Find(_to);
        }

        public INode<T>[] GetNodes()
        {
            return nodes.ToArray();
        }

        public IEdge<T, K>[] GetOutgoingEdges(INode<T> node)
        {
            return ((Node)node).GetOutgoingEdges();
        }

        public IEdge<T, K>[] GetIngoingEdges(INode<T> node)
        {
            return ((Node)node).GetIngoingEdges();
        }

        public bool Contains(INode<T> from, INode<T> to)
        {
            return Find(from, to) != null ? true : false;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (Node node in nodes) s.AppendLine(node.ToString());
            return s.ToString();
        }

        private class Node : INode<T>
        {
            public T Data { get; set; }
            public int Label { get; set; }
            public LinkedListNode<Node> ListNode { get; set; }
            private LinkedList<Edge> outgoing = new LinkedList<Edge>();
            private LinkedList<Edge> ingoing = new LinkedList<Edge>();
            public bool Mark { get; set; }

            public Node(T data)
            {
                Data = data;
                Mark = false;
            }

            public Edge Find(Node to)
            {
                foreach (Edge edge in outgoing) if (edge.To.Equals(to)) return edge;
                return null;
            }

            public Edge[] GetOutgoingEdges()
            {
                return outgoing.ToArray();
            }

            public Edge[] GetIngoingEdges()
            {
                return ingoing.ToArray();
            }

            public void AddOutgoingEdge(Edge edge)
            {
                edge.ListNodeFrom = outgoing.AddLast(edge);
            }

            public void AddIngoingEdge(Edge edge)
            {
                edge.ListNodeTo = ingoing.AddLast(edge);
            }

            public void DeleteOutgoingEdge(Edge edge)
            {
                outgoing.Remove(edge.ListNodeFrom);
            }

            public void DeleteIngoingEdge(Edge edge)
            {
                ingoing.Remove(edge.ListNodeTo);
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder();
                //int i = 0;
                //foreach (Edge edge in ingoing)
                //{
                //    s.Append(edge.ToString());
                //    if (++i < ingoing.Count) s.Append(" | ");
                //}
                //s.Append("  --> [ ");
                s.Append(Data.ToString());
                //s.Append(" ]  --> ");
                //i = 0;
                //foreach (Edge edge in outgoing)
                //{
                //    s.Append(edge.ToString());
                //    if (++i < outgoing.Count) s.Append(" | ");
                //}
                return s.ToString();
            }
        }

        private class Edge : IEdge<T, K>
        {
            public INode<T> From { get; private set; }
            public INode<T> To { get; private set; }
            public LinkedListNode<Edge> ListNodeFrom { get; set; }
            public LinkedListNode<Edge> ListNodeTo { get; set; }
            public K Data { get; set; }
            public bool Mark { get; set; }

            public Edge(Node from, Node to, K data)
            {
                From = from;
                To = to;
                Data = data;
                Mark = false;
            }

            public override string ToString()
            {
                return From.Data.ToString() + "-" + To.Data.ToString() + ":" + Data.ToString();
            }
        }

    }
}
