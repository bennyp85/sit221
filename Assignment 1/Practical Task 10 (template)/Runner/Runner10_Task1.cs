using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week05;
using DataStructures_Algorithms.Week08;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Runner
{
    class Runner10_Task1 : IRunner
    {

        static Random random = new Random(100);

        public void Run(string[] args)
        {
            string[] names = new string[] { "Sydney", "Broome", "Melbourne", "Adelaide", "Perth", "Hobart", "Darwin", "Brisbane", "Cairns", "New Castle", "Canberra", "Alice Springs" };
            Array.Sort(names);

            Graph<string, int> graph = new Graph<string, int>();
            List<INode<string>> nodes = new List<INode<string>>(names.Length+1);
            List<IEdge<string, int>> edges = new List<IEdge<string, int>>(names.Length * names.Length);

            for (int i = 0; i < names.Length; i++) nodes.Add(graph.AddNode(names[i]));
            Console.WriteLine(":: Existing Nodes: [ {0} ]", string.Join(", ", names));

            int probability = 5;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if (i == j) continue;
                    if (random.Next(10) < probability)
                    {
                        int d = random.Next(10) + 1;
                        edges.Add(graph.AddEdge(nodes[i], nodes[j], d));
                        Console.WriteLine(":: edge added: {0} -> {1} : distance {2}", nodes[i].Data, nodes[j].Data, d);
                    }
                }
            }


            //int[] distance;
            //INode<string>[] parent;

            //Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", 0, nodes[0].ToString());
            //BellmanFord.Solve(graph, 0, out distance, out parent);

            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //        string.Join(", ", GetPath(nodes[0], nodes[i], parent).Select(node => node.ToString())));
            //}

            //Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", nodes.Count / 2, nodes[nodes.Count / 2].ToString());
            //BellmanFord.Solve(graph, nodes.Count / 2, out distance, out parent);

            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //        string.Join(", ", GetPath(nodes[nodes.Count / 2], nodes[i], parent).Select(node => node.ToString())));
            //}

            //Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", nodes.Count - 1, nodes[nodes.Count - 1].ToString());
            //BellmanFord.Solve(graph, nodes.Count - 1, out distance, out parent);

            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //        string.Join(", ", GetPath(nodes[nodes.Count - 1], nodes[i], parent).Select(node => node.ToString())));
            //}

            Console.WriteLine("\n\n!!! We now change the graph and add a couple of negative weights ...\n");
            graph.Find(nodes[0], nodes[2]).Data = - 50;
            IEdge<string, int>  e = graph.Find(nodes[0], nodes[4]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[0], nodes[7]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[0], nodes[10]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[1], nodes[0]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[2], nodes[0]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[7], nodes[0]);
            edges.Remove(e); graph.DeleteEdge(e);
            e = graph.Find(nodes[9], nodes[0]);
            edges.Remove(e); graph.DeleteEdge(e);
            nodes.Add(graph.AddNode("Victor Harbour"));

            // the following two lines give us a negative cycle between Adelaide and Victor Harbour
            edges.Add(graph.AddEdge(nodes[0], nodes[12], 5));
            edges.Add(graph.AddEdge(nodes[12], nodes[0], -10));
            for (int i = 0; i < edges.Count; i++)
            {
                Console.WriteLine(":: edge : {0} -> {1} : distance {2}", edges[i].From.Data, edges[i].To.Data, edges[i].Data);
            }

            //    Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", 0, nodes[0].ToString());
            //    BellmanFord.Solve(graph, 0, out distance, out parent);

            //    for (int i = 0; i < nodes.Count; i++)
            //    {
            //        if (parent[i] == null)
            //        {
            //            Console.WriteLine("Node {0} : unreachable", nodes[i].ToString());
            //            continue;
            //        }
            //        Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //            string.Join(", ", GetPath(nodes[0], nodes[i], parent).Select(node => node.ToString())));
            //    }

            //    Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", nodes.Count / 2, nodes[nodes.Count / 2].ToString());
            //    BellmanFord.Solve(graph, nodes.Count / 2, out distance, out parent);

            //    for (int i = 0; i < nodes.Count; i++)
            //    {
            //        if (parent[i] == null)
            //        {
            //            Console.WriteLine("Node {0} : unreachable", nodes[i].ToString());
            //            continue;
            //        }
            //        Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //            string.Join(", ", GetPath(nodes[nodes.Count / 2], nodes[i], parent).Select(node => node.ToString())));
            //    }

            //    Console.WriteLine("\n\nSearching for shortest paths from node {0} <=> {1}...\n", nodes.Count - 1, nodes[nodes.Count - 1].ToString());
            //    BellmanFord.Solve(graph, nodes.Count - 1, out distance, out parent);

            //    for (int i = 0; i < nodes.Count; i++)
            ////    {
            //        if (parent[i] == null)
            //        {
            //            Console.WriteLine("Node {0} : unreachable", nodes[i].ToString());
            //            continue;
            //        }
            //        Console.WriteLine("Node {0} : shortest distance is {1} via parent {2} [ {3} ]", nodes[i].ToString(), distance[i], parent[i].ToString(),
            //            string.Join(", ", GetPath(nodes[nodes.Count - 1], nodes[i], parent).Select(node => node.ToString())));
            //    }

            Console.ReadLine();
        }

        private INode<string>[] GetPath(INode<string> origin, INode<string> destination, INode<string>[] parent)
        {
            List<INode<string>> list = new List<INode<string>>();
            INode<string> node = destination;
            while (!origin.Equals(node))
            {
                list.Add(node);
                node = parent[node.Label];
            }
            list.Add(origin);
            list.Reverse();
            return list.ToArray();
        }
    }

}
