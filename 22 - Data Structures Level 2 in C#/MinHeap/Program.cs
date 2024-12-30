using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    public class MinHeap
    {
        private List<int> Heap = new List<int>();

        public void Insert(int Value)
        {
            Heap.Add(Value);
            HeapifyUp(Heap.Count - 1);
        }

        private void HeapifyUp(int Index)
        {
            while(Index>0)
            {
                int ParentIndex = (Index - 1) / 2;
                if (Heap[Index] >= Heap[ParentIndex])
                    break;

                (Heap[Index], Heap[ParentIndex]) = (Heap[ParentIndex],Heap[Index]);

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

        public int ExtractMin()
        {
            if (Heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            int MinValue = Heap[0];

            Heap[0] = Heap[Heap.Count - 1];

            Heap.RemoveAt(Heap.Count - 1);

            HeapifyDown(0);

            return MinValue;
        }
        private void HeapifyDown(int Index)
        {
            while(Index<Heap.Count)
            {
                int LeftChildIndex = Index * 2 + 1;
                int RightChildIndex = Index * 2 + 2;

                int SmallestIndex = Index;
                if (LeftChildIndex < Heap.Count && Heap[LeftChildIndex] < Heap[SmallestIndex])
                    SmallestIndex = LeftChildIndex;

                if (RightChildIndex < Heap.Count && Heap[RightChildIndex] < Heap[SmallestIndex])
                    SmallestIndex = RightChildIndex;

                if (SmallestIndex == Index)
                    break;

                (Heap[Index], Heap[SmallestIndex]) = (Heap[SmallestIndex], Heap[Index]);

                Index = SmallestIndex;

            }
        }


        public void DisplayHeap()
        {
            Console.WriteLine("Heap Element : ");
            foreach(int item in Heap)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap();
            minHeap.Insert(10);
            minHeap.Insert(4);
            minHeap.Insert(15);
            minHeap.Insert(2);
            minHeap.Insert(8);


            minHeap.DisplayHeap();
            Console.WriteLine("Peek Miniment Elememt : " + minHeap.Peek());

            Console.WriteLine("Extract Min : " + minHeap.ExtractMin());
            minHeap.DisplayHeap();

            Console.WriteLine("Extract Min : " + minHeap.ExtractMin());
            minHeap.DisplayHeap();

            Console.ReadKey();
        }
    }
}
