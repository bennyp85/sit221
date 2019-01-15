using System;

namespace Runner
{
    class Runner09_Task1 : IRunner
    {

        static Random random = new Random(100);

        public void Run(string[] args)
        {
            string[] names = new string[] { "Sydney", "Broome", "Melbourne", "Adelaide", "Perth", "Hobart", "Darwin", "Brisbane", "Cairns", "New Castle", "Canberra", "Alice Springs" };
            Array.Sort(names);

            //Graph<string, int> graph = new Graph<string, int>();
            //INode<string>[] nodes = new INode<string>[names.Length];
            //List<IEdge<string, int>> edges = new List<IEdge<string, int>>(names.Length * names.Length);

            //for (int i = 0; i < names.Length; i++) nodes[i] = graph.AddNode(names[i]);
            //Console.WriteLine(":: Existing Nodes: [ {0} ]", string.Join(",", names));

            //int probability = 5;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    for (int j = 0; j < names.Length; j++)
            //    {
            //        if (i == j) continue;
            //        if (random.Next(10) < probability)
            //        {
            //            edges.Add(graph.AddEdge(nodes[i], nodes[j], 1));
            //            Console.WriteLine(":: edge added: {0} -> {1}", nodes[i].Data, nodes[j].Data);
            //        }
            //    }
            //}
            ////Console.WriteLine("\nPrinting the content of the graph...\n{0}\n", graph.ToString());

            //string[] traverse_DFS = graph.DFS(nodes[0]).Select(v => v.Data).ToArray();
            //Console.WriteLine("\nPrinting the content of traverse_DFS...\n[ {0} ]\n", string.Join(",", traverse_DFS));


            //INode<string>[][] traverse_BFS = graph.BFS(nodes[0]);
            //for (int i=0; i< traverse_BFS.Length; i++ )
            //{
            //    Console.WriteLine("\nPrinting the content of traverse_BFS (level {0})...\n[ {1} ]\n", i, string.Join(",", traverse_BFS[i].Select(v => v.Data).ToArray()));
            //}

            Console.ReadLine();
        }
    }

}
