using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    public class PriorityQueueNode
    {
        public string Name { get; set; }
        public int Priority { get; set; }

        public PriorityQueueNode(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        


    }

    public class MinHeapPriorityQueue
    {
        private List<PriorityQueueNode> Heap = new List<PriorityQueueNode>();

        public void Enqueue(string Name,int Priority)
        {
            var Node = new PriorityQueueNode(Name, Priority);
            Heap.Add(Node);
            HeapifyUp(Heap.Count - 1);
        }

        private void HeapifyUp(int Index)
        {
            while (Index > 0)
            {
                int ParentIndex = (Index - 1) / 2;
                if (Heap[Index].Priority >= Heap[ParentIndex].Priority)
                    break;

                (Heap[Index], Heap[ParentIndex]) = (Heap[ParentIndex], Heap[Index]);

                Index = ParentIndex;
            }
        }

        public PriorityQueueNode Peek()
        {
            if (Heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return Heap[0];
        }

        public PriorityQueueNode Dequeue()
        {
            if (Heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            var MinNode = Heap[0];

            Heap[0] = Heap[Heap.Count - 1];

            Heap.RemoveAt(Heap.Count - 1);

            HeapifyDown(0);

            return MinNode;
        }
        private void HeapifyDown(int Index)
        {
            while (Index < Heap.Count)
            {
                int LeftChildIndex = Index * 2 + 1;
                int RightChildIndex = Index * 2 + 2;

                int SmallestIndex = Index;
                if (LeftChildIndex < Heap.Count && Heap[LeftChildIndex].Priority < Heap[SmallestIndex].Priority)
                    SmallestIndex = LeftChildIndex;

                if (RightChildIndex < Heap.Count && Heap[RightChildIndex].Priority < Heap[SmallestIndex].Priority)
                    SmallestIndex = RightChildIndex;

                if (SmallestIndex == Index)
                    break;

                (Heap[Index], Heap[SmallestIndex]) = (Heap[SmallestIndex], Heap[Index]);

                Index = SmallestIndex;

            }
        }


        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeapPriorityQueue pq = new MinHeapPriorityQueue();

            Console.WriteLine("Inserting elements into the Priority Queue...\n");

            Console.WriteLine("Inserting (Task 1, 5)");
            Console.WriteLine("Inserting (Task 2, 3)");
            Console.WriteLine("Inserting (Task 3, 4)");
            Console.WriteLine("Inserting (Task 4, 1)");
            Console.WriteLine("Inserting (Task 5, 2)");

            pq.Enqueue("Task 1", 5);
            pq.Enqueue("Task 2", 3);
            pq.Enqueue("Task 3", 4);
            pq.Enqueue("Task 4", 1);
            pq.Enqueue("Task 5", 2);

            // Peek the minimum priority element
            Console.WriteLine("\nPeek Minimum Priority Element: Name = " + pq.Peek().Name + ", Priority = " + pq.Peek().Priority);

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Priority Queue:");
            var extractedNode = pq.Dequeue();
            Console.WriteLine("\nExtracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Dequeue();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Dequeue();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Dequeue();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Dequeue();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);



            Console.ReadKey();

        }
    }
}
