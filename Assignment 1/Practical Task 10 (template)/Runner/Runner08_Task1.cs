using DataStructures_Algorithms.Week01;
using DataStructures_Algorithms.Week05;
using DataStructures_Algorithms.Week08;
using System;
using System.Collections.Generic;

namespace Runner
{
    class Runner08_Task1 : IRunner
    {
        public void Run(string[] args)
        {
            Graph<string, int> graph = new Graph<string, int>();

            Console.WriteLine(":: Execute command: {0}", "graph.AddNode(\"Sydney\")");
            INode<string> sydney = graph.AddNode("Sydney");

            Console.WriteLine(":: Execute command: {0}", "graph.AddNode(\"Melbourne\")");
            INode<string> melbourne = graph.AddNode("Melbourne");

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(sydney, melbourne, 878)");
            IEdge<string,int> sydney_melbourne = graph.AddEdge(sydney, melbourne, 878);

            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine(":: Execute command: {0}", "graph.AddNode(\"Adelaide\")");
            INode<string> adelaide = graph.AddNode("Adelaide");

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(melbourne, adelaide, 726)");
            IEdge<string, int> melbourne_adelaide = graph.AddEdge(melbourne, adelaide, 726);

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(adelaide, melbourne, 726)");
            IEdge<string, int> adelaide_melbourne = graph.AddEdge(adelaide, melbourne, 726);

            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine("graph.Contains(melbourne, adelaide): {0}", graph.Contains(melbourne, adelaide) == true ? "correct" : "incorrect");
            Console.WriteLine("graph.Contains(sydney, adelaide): {0}", graph.Contains(sydney, adelaide) != true ? "correct" : "incorrect");

            IEdge<string, int> check = null; int count = 0;
            Console.WriteLine("graph.Find(sydney, adelaide): {0}", (check = graph.Find(sydney, adelaide)) == null ? "does not exist (correct)" : "incorrect");
            Console.WriteLine("graph.Find(sydney, melbourne): {0}", (check = graph.Find(sydney, melbourne)) != null ? check.ToString() : "incorrect");
            Console.WriteLine("graph.NumVertices: {0}", (count = graph.NumVertices) == 3 ? "3 (correct)" : count+ " (incorrect)");
            Console.WriteLine("graph.NumEdges: {0}", (count = graph.NumEdges) == 3 ? "3 (correct)" : count + " (incorrect)");

            Console.WriteLine(":: Execute command: {0}", "graph.DeleteEdge(sydney, melbourne)");
            graph.DeleteEdge(sydney, melbourne);
            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine("graph.NumVertices: {0}", (count = graph.NumVertices) == 3 ? "3 (correct)" : count + " (incorrect)");
            Console.WriteLine("graph.NumEdges: {0}", (count = graph.NumEdges) == 2 ? "2 (correct)" : count + " (incorrect)");

            Console.WriteLine(":: Execute command: {0}", "graph.DeleteEdge(adelaide_melbourne)");
            graph.DeleteEdge(adelaide_melbourne);
            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(sydney, melbourne, 878)");
            sydney_melbourne = graph.AddEdge(sydney, melbourne, 878);

            INode<string> darwin = graph.AddNode("Darwin");
            INode<string> perth = graph.AddNode("Perth");

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(melbourne, darwin, 3741)");
            IEdge<string, int> melbourne_darwin = graph.AddEdge(melbourne, darwin, 3741);

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(melbourne, perth, 3406)");
            IEdge<string, int> melbourne_perth = graph.AddEdge(melbourne, perth, 3406);

            Console.WriteLine(":: Execute command: {0}", "graph.AddEdge(perth, darwin, 4041)");
            IEdge<string, int> perth_darwin = graph.AddEdge(perth, darwin, 4041);
            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine(":: Execute command: {0}", "graph.DeleteNode(melbourne)");
            graph.DeleteNode(melbourne);
            Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            Console.WriteLine("graph.NumVertices: {0}", (count = graph.NumVertices) == 4 ? "4 (correct)" : count + " (incorrect)");
            Console.WriteLine("graph.NumEdges: {0}", (count = graph.NumEdges) == 1 ? "1 (correct)" : count + " (incorrect)");

            Console.WriteLine("\nPrinting the nodes of the graph...");
            INode<string>[] nodes = graph.GetNodes();
            for (int i = 0; i<nodes.Length; i++) Console.WriteLine("Node {0}:\t{1} ",i,nodes[i].ToString());

            Console.WriteLine("\nPrinting the outgoing nodes of Perth...");
            IEdge<string,int>[] edges = graph.GetOutgoingEdges(perth);
            for (int i = 0; i < edges.Length; i++) Console.WriteLine("Edge {0}:\t{1} ", i, edges[i].ToString());

            Console.WriteLine("\nPrinting the ingoing nodes of Darwin...");
            edges = graph.GetIngoingEdges(darwin);
            for (int i = 0; i < edges.Length; i++) Console.WriteLine("Edge {0}:\t{1} ", i, edges[i].ToString());

            Console.ReadLine();
        }
    }

}
