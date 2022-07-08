using PrograIII_TPO;

Graph Graph = new Graph(7);

Graph.AddEdge(1, 3);
Graph.AddEdge(1, 4);
Graph.AddEdge(2, 5);
Graph.AddEdge(2, 6);
Graph.AddEdge(3, 2);
Graph.AddEdge(3, 4);
Graph.AddEdge(3, 5);
Graph.AddEdge(4, 6);

Console.WriteLine("BFS Partiendo del nodo 1");
Algorithms.BreadthFirstSearch(Graph, 1);

Console.WriteLine("DFS Partiendo del nodo 1");
Algorithms.RunDepthFirstSearch(Graph, 1);