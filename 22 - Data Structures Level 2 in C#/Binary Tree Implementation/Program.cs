using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Implementation
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T Value)
        {
            this.Value = Value;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T Value)
        {
            BinaryTreeNode<T> NewNode = new BinaryTreeNode<T>(Value);

            if(Root == null)
            {
                Root = NewNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue=new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                BinaryTreeNode<T> Current = queue.Dequeue();
                if (Current.Left == null)
                {
                    Current.Left = NewNode;
                    break;
                }
                else
                {
                    queue.Enqueue(Current.Left);
                }

                if (Current.Right == null)
                {
                    Current.Right = NewNode;
                    break;
                }
                else
                {
                    queue.Enqueue(Current.Right);
                }

            }


        }

        public void PrintTree()
        {
            PrintTree(this.Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> Root,int Space)
        {
            int Count = 8;
            if (Root == null)
                return;

            Space += Count;

            PrintTree(Root.Right, Space);

            Console.WriteLine();
            for(int i=Count;i<Space;i++)
                Console.Write(" ");

            Console.WriteLine(Root.Value);

            PrintTree(Root.Left, Space);
        }

        private void PreOrderTraversal(BinaryTreeNode<T> Root)
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
        private void PostOrderTraversal(BinaryTreeNode<T> Root)
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

        private void InOrderTraversal(BinaryTreeNode<T> Root)
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

        private void LevelOrderTraversal(BinaryTreeNode<T> Root)
        {
            if (Root == null)
               return;

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                BinaryTreeNode<T> Current = queue.Dequeue();

                Console.Write(Current.Value+"  ");
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


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14\n");

            for(int i=0;i<=14;i++)
            {
                binaryTree.Insert(i);
            }

            binaryTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current --> Left SubTree --> Right SubTree):");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("\nPostorder Traversal (Left SubTree --> Right SubTree --> Current):");
            binaryTree.PostOrderTraversal();

            Console.WriteLine("\nInOrder Traversal (Left SubTree --> Current --> Right SubTree ):");
            binaryTree.InOrderTraversal();

            Console.WriteLine("\nLevelOrder Traversal :");
            binaryTree.LevelOrderTraversal();

            Console.ReadKey();
        }
    }
}
