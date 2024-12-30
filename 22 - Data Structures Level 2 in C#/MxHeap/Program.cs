using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxHeap
{
    public class MaxHeap
    {
        private List<int> Heap = new List<int>();

        public void Insert(int Value)
        {
            Heap.Add(Value);
            HeapifyUp(Heap.Count - 1);
        }

        private void HeapifyUp(int Index)
        {
            while (Index > 0)
            {
                int ParentIndex = (Index - 1) / 2;
                if (Heap[Index] <= Heap[ParentIndex])
                    break;

                (Heap[Index], Heap[ParentIndex]) = (Heap[ParentIndex], Heap[Index]);

                Index = ParentIndex;
            }
        }

        public int Peek()
        {
            if (Heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return Heap[0];
        }

        public int ExtractMax()
        {
            if (Heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            int MaxValue = Heap[0];

            Heap[0] = Heap[Heap.Count - 1];

            Heap.RemoveAt(Heap.Count - 1);

            HeapifyDown(0);

            return MaxValue;
        }
        private void HeapifyDown(int Index)
        {
            while (Index < Heap.Count)
            {
                int LeftChildIndex = Index * 2 + 1;
                int RightChildIndex = Index * 2 + 2;

                int LargestIndex = Index;

                if (LeftChildIndex < Heap.Count && Heap[LeftChildIndex] > Heap[LargestIndex])
                    LargestIndex = LeftChildIndex;

                if (RightChildIndex < Heap.Count && Heap[RightChildIndex] > Heap[LargestIndex])
                    LargestIndex = RightChildIndex;

                if (LargestIndex == Index)
                    break;

                (Heap[Index], Heap[LargestIndex]) = (Heap[LargestIndex], Heap[Index]);

                Index = LargestIndex;

            }
        }


        public void DisplayHeap()
        {
            Console.WriteLine("Heap Element : ");
            foreach (int item in Heap)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxHeap maxHeap = new MaxHeap();

            Console.WriteLine("Inserting elements into the Max-Heap...\n");
            maxHeap.Insert(10);
            maxHeap.Insert(4);
            maxHeap.Insert(15);
            maxHeap.Insert(2);
            maxHeap.Insert(8);

            // Display the heap after insertion
            maxHeap.DisplayHeap();

            Console.WriteLine("\nPeek Maximum Element: Maximum Element is: " + maxHeap.Peek());

            // Display the heap after insertion, note that the maximum value is not deleted.
            maxHeap.DisplayHeap();

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Max-Heap:");
            Console.WriteLine("Extracted Maximum: " + maxHeap.ExtractMax());
            maxHeap.DisplayHeap();

            Console.WriteLine("\nExtracted Maximum: " + maxHeap.ExtractMax());
            maxHeap.DisplayHeap();

            Console.ReadKey();
        }
    }
}
