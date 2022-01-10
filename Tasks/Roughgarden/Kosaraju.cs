using System.Collections.Generic;

namespace Tasks.Roughgarden
{
    public class Kosaraju
    {
        public void Process()
        {
            Graph graph;
            Graph gr;
            var stack = new Stack<int>();
            var top = 0;
        }


        private void TopoSort(int[][] graph)
        {
            
            
        }

        private void DFSTopo(int[][] graph, int s)
        {
            
        }
    }

    public class Graph
    {
        public int V;
        public int[] Visited;
        public AdjList[] Array;

        public static Graph Create(int v)
        {
            var g = new Graph()
            {
                V = v,
                Array = new AdjList[v]
            };
            return g;
        }

        public void AddEdge(Graph gr, int src, int dest, int weight)
        {
            var newNode = new AdjListNode(dest, weight)
            {
                Next = Array[src].Head
            };
            Array[src].Head = newNode;
            GetTranspose(gr, src, dest, weight);
        }

        private void GetTranspose(Graph gr, int src, int dest, int weight)
        {
            var newNode = new AdjListNode(src, weight)
            {
                Next = gr.Array[dest].Head
            };
            gr.Array[dest].Head = newNode;
        }
    }

    public class AdjListNode
    {
        public int Dest;
        public int Weight;
        public AdjListNode Next;

        public AdjListNode(int dest, int weight)
        {
            Dest = dest;
            Weight = weight;
        }
    }

    public class AdjList
    {
        public AdjListNode Head;
    }
}