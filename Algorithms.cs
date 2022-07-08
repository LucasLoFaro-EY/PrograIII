using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIII_TPO
{
    public static class Algorithms
    {
        
        public static void BreadthFirstSearch(Graph graph, int start)
        {
            Boolean[] Visited = new Boolean[graph.Length];

            Queue<int> Queue = new Queue<int>();

            Visited[start] = true;
            Queue.Enqueue(start);

            while (Queue.Count != 0)
            {
                start = Queue.Dequeue();
                Console.WriteLine("|" + start + "|");

                foreach (var Node in graph.Siblings[start])
                {
                    if (!Visited[Node])
                    {
                        Visited[Node] = true;
                        Queue.Enqueue(Node);
                    }
                }
            }
        }
        static void DepthFirstSearch(Graph graph, int start, Boolean[] visited)
        {
            visited[start] = true;
            Console.WriteLine("|" + start + "|");

            foreach (var Node in graph.Siblings[start])
                if (!visited[Node])
                    DepthFirstSearch(graph, Node, visited);
        }

        public static void RunDepthFirstSearch(Graph graph, int start)
        {
            Boolean[] Visited = new Boolean[graph.Length];
            DepthFirstSearch(graph, start, Visited);
        }
    }
}
