using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week08
{
    public partial class Graph<T, K>
    {

        public INode<T>[][] BFS(INode<T> node)
        {
            NullifyMarking();
            List<INode<T>[]> result = new List<INode<T>[]>(NumVertices);
            int i = 0;
            Node vertex = (Node)node;
            vertex.Mark = true;
            result.Add(new Node[] { vertex });
            while (result[i].Count() != 0)
            {
                List<INode<T>> list = new List<INode<T>>(NumVertices);
                foreach (Node v in result[i])
                {
                    List<IEdge<T, K>> out_edges = new List<IEdge<T, K>>(GetOutgoingEdges(v));
                    foreach (IEdge<T, K> e in out_edges)
                    {
                        Edge edge = (Edge)e;
                        if (edge.Mark) continue;
                        edge.Mark = true;
                        Node adjacent_node = (Node)edge.To;
                        if (!adjacent_node.Mark)
                        {
                            adjacent_node.Mark = true;
                            list.Add(adjacent_node);
                        }
                    }
                }
                result.Add(list.ToArray());
                i++;
            }
            result.RemoveAt(result.Count - 1);
            return result.ToArray();
        }

        public INode<T>[] DFS(INode<T> node)
        {
            NullifyMarking();
            List<INode<T>> result = new List<INode<T>>(NumVertices);
            DFS(result, (Node)node);
            return result.ToArray();
        }

        private void NullifyMarking()
        {
            foreach (Node node in GetNodes())
            {
                node.Mark = false;
                foreach (Edge edge in node.GetOutgoingEdges()) edge.Mark = false;
            }
        }

        private void DFS(List<INode<T>> marking, Node node)
        {
            node.Mark = true;
            marking.Add(node);
            List<IEdge<T, K>> out_edges = new List<IEdge<T, K>>(GetOutgoingEdges(node));
            out_edges.Sort(new DFSComparator());
            foreach (IEdge<T, K> e in out_edges)
            {
                Edge edge = (Edge)e;
                if (edge.Mark) continue;
                Node adjacent_node = (Node)edge.To;
                edge.Mark = true;
                if (!adjacent_node.Mark) DFS(marking, adjacent_node);
            }
        }

        private class DFSComparator : IComparer<IEdge<T, K>>
        {
            public int Compare(IEdge<T, K> x, IEdge<T, K> y)
            {
                return Comparer<T>.Default.Compare(x.To.Data, y.To.Data);
            }
        }

    }
}
