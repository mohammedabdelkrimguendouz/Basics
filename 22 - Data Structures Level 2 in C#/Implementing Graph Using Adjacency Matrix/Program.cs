using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Implementing_Graph_Using_Adjacency_Matrix.Graph;

namespace Implementing_Graph_Using_Adjacency_Matrix
{
    public class Graph
    {
        public enum enGraphDirectionType { Directed,UnDirected}
        private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.UnDirected;
        private int[,] _AdjacencyMatrix;
        private Dictionary<string,int> _VertexDictionary;
        private int _NumberOfVertices;

        public Graph(List<string> Vertices, enGraphDirectionType GraphDirectionType)
        {
            _GraphDirectionType = GraphDirectionType;
            _NumberOfVertices = Vertices.Count;
            _AdjacencyMatrix = new int[_NumberOfVertices, _NumberOfVertices];

            _VertexDictionary = new Dictionary<string, int>();

            for (int i =0;i<_NumberOfVertices;i++)
            {
                _VertexDictionary.Add(Vertices[i], i);
            }
        }

        public void AddEdge(string Source,string Destination,int Weight)
        {
            if (!_VertexDictionary.ContainsKey(Source) || !_VertexDictionary.ContainsKey(Destination))
                return;

            int SourceIndex = _VertexDictionary[Source];
            int DestinationIndex = _VertexDictionary[Destination];

            _AdjacencyMatrix[SourceIndex, DestinationIndex] = Weight;

            if(_GraphDirectionType==enGraphDirectionType.UnDirected)
            {
                _AdjacencyMatrix[DestinationIndex, SourceIndex] = Weight;
            }
                

        }

        public int GetInDegree(string Vertex)
        {
            int Degree = 0;
            if (_VertexDictionary.ContainsKey(Vertex))
            {
                int VertexIndex = _VertexDictionary[Vertex];

                for (int i=0;i<_NumberOfVertices;i++)
                {
                    if (_AdjacencyMatrix[i, VertexIndex] > 0)
                        Degree++;
                }
            }


            return Degree;
        }

        public int GetOutDegree(string Vertex)
        {
            int Degree = 0;
            if (_VertexDictionary.ContainsKey(Vertex))
            {
                int VertexIndex = _VertexDictionary[Vertex];

                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    if (_AdjacencyMatrix[VertexIndex, i] > 0)
                        Degree++;
                }
            }


            return Degree;
        }

        public void RemoveEdge(string Source, string Destination)
        {
            if (!_VertexDictionary.ContainsKey(Source) || !_VertexDictionary.ContainsKey(Destination))
                return;

            int SourceIndex = _VertexDictionary[Source];
            int DestinationIndex = _VertexDictionary[Destination];

            _AdjacencyMatrix[SourceIndex, DestinationIndex] = 0;

            if (_GraphDirectionType == enGraphDirectionType.UnDirected)
            {
                _AdjacencyMatrix[DestinationIndex, SourceIndex] = 0;
            }
        }

        public void DisplayGraph()
        {
            Console.Write("  ");
            foreach (var Vertex in _VertexDictionary)
            {
                Console.Write(Vertex.Key + " ");
            }
            Console.WriteLine("");

            foreach (var Vertex in _VertexDictionary)
            {
                Console.Write(Vertex.Key+" ");
                for(int i=0 ; i<_NumberOfVertices;i++ )
                {
                    Console.Write(_AdjacencyMatrix[Vertex.Value, i]+" ");
                }
                Console.WriteLine("");
            }

        }

        public bool IsEdge(string Source, string Destination)
        {
            if (!_VertexDictionary.ContainsKey(Source) || !_VertexDictionary.ContainsKey(Destination))
                return false;

            int SourceIndex = _VertexDictionary[Source];
            int DestinationIndex = _VertexDictionary[Destination];

            return (_AdjacencyMatrix[SourceIndex, DestinationIndex] > 0);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Vertices = new List<string>() { "A", "B", "C", "D", "E" };

            Console.WriteLine("\n----------------- Exemple 1 (Undirected Graph)---------------=====");

            Graph graph = new Graph(Vertices, Graph.enGraphDirectionType.UnDirected);

            graph.AddEdge("A", "B", 1);
            graph.AddEdge("A", "C", 1);
            graph.AddEdge("B", "E", 1);
            graph.AddEdge("B", "D", 1);
            graph.AddEdge("C", "D", 1);
            graph.AddEdge("D", "E", 1);

            graph.DisplayGraph();




            Console.WriteLine("\n----------------- Exemple 2 (Directed Graph)---------------=====");

            Graph graph2 = new Graph(Vertices, Graph.enGraphDirectionType.Directed);

            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);

            graph2.DisplayGraph();

            Console.WriteLine("\nOut Degree Of B :" + graph2.GetOutDegree("B"));
            Console.WriteLine("\nIn Degree Of B :" + graph2.GetInDegree("B"));
            Console.WriteLine("\nIs Exist Edge Between A And B : " + graph2.IsEdge("A", "B"));
            Console.WriteLine("\nIs Exist Edge Between B And A : " + graph2.IsEdge("B", "A"));




            Console.WriteLine("\n----------------- Exemple 3 (UnDirected && Weighted Graph)---------------=====");

            Graph graph3 = new Graph(Vertices, Graph.enGraphDirectionType.UnDirected);

            graph3.AddEdge("A", "B", 5);
            graph3.AddEdge("A", "C", 3);
            graph3.AddEdge("B", "E", 2);
            graph3.AddEdge("B", "D", 12);
            graph3.AddEdge("C", "D", 10);
            graph3.AddEdge("D", "E", 7);

            graph3.DisplayGraph();

            Console.WriteLine("\nIs Exist Edge Between A And B : " + graph3.IsEdge("A","B"));

            graph3.RemoveEdge("A", "B");
            Console.WriteLine("\nAfter Remove Edge Between A And B");

            Console.WriteLine("\nIs Exist Edge Between A And B : " + graph3.IsEdge("A", "B"));
            graph3.DisplayGraph();
            Console.Write("\nPress Any Key...");
            Console.ReadKey();
        }
    }
}
