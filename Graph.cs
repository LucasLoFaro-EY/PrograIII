using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIII_TPO
{
    public class Graph
    {
        public int Length { get; set; }
        public LinkedList<int>[] Siblings;

        public Graph(int length)
        {
            Length = length;
            Siblings = new LinkedList<int>[Length];

            for (int i = 0; i < length; i++)
            {
                Siblings[i] = new LinkedList<int>();
            }

        }
        public void AddEdge(int source, int destination)
        {
            Siblings[source].AddLast(destination);
        }
    }
}
