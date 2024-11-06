using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Graph_Using_Adjacency_List
{
    public class Graph
    {
        public enum enGraphDirectionType { Directed, UnDirected }
        private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.UnDirected;
        
        private Dictionary<string, List<Tuple<string,int>>> _AdjacencyList;
        private int _NumberOfVertices;

        public Graph(HashSet<string> Vertices, enGraphDirectionType GraphDirectionType)
        {
            _GraphDirectionType = GraphDirectionType;
            _NumberOfVertices = Vertices.Count;


            _AdjacencyList = new Dictionary<string, List<Tuple<string, int>>>();


            foreach (string Vertex in Vertices)
            {
                _AdjacencyList.Add(Vertex,new List<Tuple<string, int>>());
            }
        }

        public void AddEdge(string Source, string Destination, int Weight)
        {
            if (!_AdjacencyList.ContainsKey(Source) || !_AdjacencyList.ContainsKey(Destination))
                return;


            _AdjacencyList[Source].Add(new Tuple<string, int>(Destination, Weight));

            if (_GraphDirectionType == enGraphDirectionType.UnDirected)
            {
                _AdjacencyList[Destination].Add(new Tuple<string, int>(Source, Weight));
            }


        }

        public int GetInDegree(string Vertex)
        {
            int InDegree = 0;
            if (_AdjacencyList.ContainsKey(Vertex))
            {
               foreach(var Source in _AdjacencyList)
               {
                    Source.Value.ForEach(edge =>
                    {
                        if (edge.Item1 == Vertex)
                        {
                            InDegree++;
                        }
                    });

                }

            }


            return InDegree;
        }

        public int GetOutDegree(string Vertex)
        {
            int OutDegree = 0;
            if (_AdjacencyList.ContainsKey(Vertex))
            {
                OutDegree = _AdjacencyList[Vertex].Count;
            }


            return OutDegree;
        }

        public void RemoveEdge(string Source, string Destination)
        {
            if (!_AdjacencyList.ContainsKey(Source) || !_AdjacencyList.ContainsKey(Destination))
                return;

            _AdjacencyList[Source].RemoveAll(edge => edge.Item1 == Destination);


            if (_GraphDirectionType == enGraphDirectionType.UnDirected)
            {
                _AdjacencyList[Destination].RemoveAll(edge => edge.Item1 == Source);
            }
        }

        public void DisplayGraph()
        {
            foreach (var Vertex in _AdjacencyList)
            {
                Console.Write(Vertex.Key + " => ");
                Vertex.Value.ForEach(edge =>
                {
                    Console.Write(edge.Item1 + "(" + edge.Item2+")  ");
                });
                Console.WriteLine("");
            }

        }

        public bool IsEdge(string Source, string Destination)
        {
            if (!_AdjacencyList.ContainsKey(Source) || !_AdjacencyList.ContainsKey(Destination))
                return false;

            

            return (_AdjacencyList[Source].Any(edge =>(edge.Item1==Destination)));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Vertices = new HashSet<string>() { "A", "B", "C", "D", "E" };

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

            Console.WriteLine("\nIs Exist Edge Between A And B : " + graph3.IsEdge("A", "B"));

            graph3.RemoveEdge("A", "B");
            Console.WriteLine("\nAfter Remove Edge Between A And B");

            Console.WriteLine("\nIs Exist Edge Between A And B : " + graph3.IsEdge("A", "B"));
            graph3.DisplayGraph();
            Console.Write("\nPress Any Key...");
            Console.ReadKey();
        }
    }
}
