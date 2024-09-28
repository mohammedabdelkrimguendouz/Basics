using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Implementation
{
    public class BinarySearchTreeNode<T> 
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T Value)
        {
            this.Value = Value;
            this.Left = null;
            this.Right = null;
        }
    }



    public class BinarySearchTree<T> where T :IComparable<T>
    {
        public BinarySearchTreeNode<T> Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void InsertRecursion(T Value)
        {

             Root= InsertRecursion(this.Root, Value);
        }
        private BinarySearchTreeNode<T> InsertRecursion(BinarySearchTreeNode<T> Root, T Value)
        {

            if (Root == null)
            {
               return new BinarySearchTreeNode<T>(Value);
            }
            else if(Value.CompareTo(Root.Value)<0)
            {
                 Root.Left= InsertRecursion(Root.Left, Value);
            }
            else if (Value.CompareTo(Root.Value) > 0)
            {
                Root.Right = InsertRecursion(Root.Right, Value);
            }

            return Root;
        }
        
        public void Insert(T Value)
        {

            if (Root == null)
            {
                this.Root = new BinarySearchTreeNode<T>(Value) ;
                return;
            }

            BinarySearchTreeNode<T> Prev = null;
            BinarySearchTreeNode<T> Curr = Root;

            while (Curr != null)
            {
                if(Value.CompareTo(Curr.Value)<0)
                {
                    Prev = Curr;
                    Curr = Curr.Left;
                }
                else if(Value.CompareTo(Curr.Value) > 0)
                {
                    Prev = Curr;
                    Curr = Curr.Right;
                }
            }
            if (Value.CompareTo(Prev.Value) < 0)
                Prev.Left = new BinarySearchTreeNode<T>(Value);
            else if (Value.CompareTo(Prev.Value) > 0)
                Prev.Right = new BinarySearchTreeNode<T>(Value);
        }

        public void PrintTree()
        {
            PrintTree(this.Root, 0);
        }

        private void PrintTree(BinarySearchTreeNode<T> Root, int Space)
        {
            int Count = 8;
            if (Root == null)
                return;

            Space += Count;

            PrintTree(Root.Right, Space);

            Console.WriteLine();
            for (int i = Count; i < Space; i++)
                Console.Write(" ");

            Console.WriteLine(Root.Value);

            PrintTree(Root.Left, Space);
        }

        private void PreOrderTraversal(BinarySearchTreeNode<T> Root)
        {
            if (Root != null)
            {
                Console.Write($"{Root.Value}  ");
                PreOrderTraversal(Root.Left);
                PreOrderTraversal(Root.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(this.Root);
            Console.WriteLine();
        }
        private void PostOrderTraversal(BinarySearchTreeNode<T> Root)
        {
            if (Root != null)
            {
                PostOrderTraversal(Root.Left);
                PostOrderTraversal(Root.Right);
                Console.Write($"{Root.Value}  ");
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(this.Root);
            Console.WriteLine();
        }

        private void InOrderTraversal(BinarySearchTreeNode<T> Root)
        {
            if (Root != null)
            {
                InOrderTraversal(Root.Left);
                Console.Write($"{Root.Value}  ");
                InOrderTraversal(Root.Right);
            }
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(this.Root);
            Console.WriteLine();
        }

        private void LevelOrderTraversal(BinarySearchTreeNode<T> Root)
        {
            if (Root == null)
                return;

            Queue<BinarySearchTreeNode<T>> queue = new Queue<BinarySearchTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                BinarySearchTreeNode<T> Current = queue.Dequeue();

                Console.Write(Current.Value + "  ");
                if (Current.Left != null)
                {
                    queue.Enqueue(Current.Left);
                }


                if (Current.Right != null)
                {
                    queue.Enqueue(Current.Right);
                }

            }
        }

        public void LevelOrderTraversal()
        {
            LevelOrderTraversal(this.Root);
            Console.WriteLine();
        }

        public bool SearchRecursion(T Value)
        {
            return Search(this.Root, Value)!=null;
        }
        private BinarySearchTreeNode<T> SearchRecursion( BinarySearchTreeNode<T> Root, T Value)
        {
            if (Root == null || Value.Equals(Root.Value))
                return Root;

            if (Value.CompareTo(Root.Value) < 0)
                return Search(Root.Left, Value);

            else
                return Search(Root.Right, Value);
        }

        public bool Search(T Value)
        {
            return Search(this.Root, Value)!=null;
        }
        private BinarySearchTreeNode<T> Search(BinarySearchTreeNode<T> Root,T Value)
        {
           
            BinarySearchTreeNode<T> Curr = Root;
            while(Curr!=null && !Curr.Value.Equals(Value))
            {
                if (Value.CompareTo(Curr.Value) < 0)
                    Curr = Curr.Left;
                else
                    Curr = Curr.Right;
            }
            return Curr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            Console.WriteLine("Values to be inserted: 45,35,50,20,40,49,60\n");

            //binarySearchTree.InsertRecursion(45);
            //binarySearchTree.InsertRecursion(35);
            //binarySearchTree.InsertRecursion(50);
            //binarySearchTree.InsertRecursion(20);
            //binarySearchTree.InsertRecursion(40);
            //binarySearchTree.InsertRecursion(49);
            //binarySearchTree.InsertRecursion(60);

            binarySearchTree.Insert(45);
            binarySearchTree.Insert(35);
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(49);
            binarySearchTree.Insert(60);

            Console.WriteLine("Deos BST Contain 20 : " + binarySearchTree.SearchRecursion(20));
            Console.WriteLine("Deos BST Contain 50 : " + binarySearchTree.SearchRecursion(50));
            Console.WriteLine("Deos BST Contain 60 : " + binarySearchTree.SearchRecursion(60));
            Console.WriteLine("Deos BST Contain 100 : " + binarySearchTree.SearchRecursion(100));
            Console.WriteLine("Deos BST Contain 18 : " + binarySearchTree.SearchRecursion(18));

            Console.WriteLine("Deos BST Contain 49 : " + binarySearchTree.Search(40));
            Console.WriteLine("Deos BST Contain 40 : " + binarySearchTree.Search(40));
            Console.WriteLine("Deos BST Contain 45 : " + binarySearchTree.Search(45));
            Console.WriteLine("Deos BST Contain 35 : " + binarySearchTree.Search(35));
            Console.WriteLine("Deos BST Contain 2 : " + binarySearchTree.Search(2));
            Console.WriteLine("Deos BST Contain 150 : " + binarySearchTree.Search(150));

            binarySearchTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current --> Left SubTree --> Right SubTree):");
            binarySearchTree.PreOrderTraversal();

            Console.WriteLine("\nPostorder Traversal (Left SubTree --> Right SubTree --> Current):");
            binarySearchTree.PostOrderTraversal();

            Console.WriteLine("\nInOrder Traversal (Left SubTree --> Current --> Right SubTree ):");
            binarySearchTree.InOrderTraversal();

            Console.WriteLine("\nLevelOrder Traversal :");
            binarySearchTree.LevelOrderTraversal();

            Console.ReadKey();
        }
    }
}
