# Trabajo Práctico Obligatorio

# **UADE**

# MRI PROGRAMACION III - TPO 2022

| Integrante       | Legajo      |
| ---------------- | ----------- |
| Aguirre, Rodrigo | LU: 1105600 |
| Lo Faro, Lucas   | LU: 1101555  |

**Profesor: Rodriguez, Guillermo**

---

Para representar grafos y algoritmos, elegimos **BFS**(_Búsqueda en Anchura_) y **DFS**(_Búsqueda en Profundidad_).


---

## Los algoritmos son los siguientes:

### **a) BFS**

```
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
```

Donde los parámetros son el grafo y el nodo, y como resultado obtengo los nodos alcanzados desde el primer nodo que elegí.

#### Secuencia:

![BFS_Sequence](https://user-images.githubusercontent.com/98764324/178024603-7f2eb92d-c562-457f-94cd-4238b1963aff.jpg)

---

_Output de la función:_

` 
|1| |3| |4| |2| |5| |6| 
`

### **b) DFS**

```
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

```

Donde los parámetros son el grafo y el origen, y como resultado obtengo los nodos alcanzados desde el primer nodo que elegí. En esta implementación utilizamos una cola.

#### Secuencia:

![DFS_Sequence](https://user-images.githubusercontent.com/98764324/178025024-9a391934-b58a-4dcd-b145-6ccd55894e99.jpg)

---

_Output de la función:_
` 
|1| |3| |2| |5| |6| |4| 
`
