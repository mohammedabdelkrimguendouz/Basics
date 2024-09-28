using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace General_Tree_Implementation_in_C_
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children= new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> Child) => Children.Add(Child);

        public TreeNode<T> Find(T value)
        {
            if(EqualityComparer<T>.Default.Equals(Value,value))
                return this;

            foreach(var Child in Children)
            {
                var Found = Child.Find(value);
                if (Found != null)
                    return Found;
            }
            return null;
        }

    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T RootValue)
        {
            Root = new TreeNode<T>(RootValue);
        }

        public void PrintTree( string indent = " ")
        {
            PrintTree(this.Root, indent);
        }
        private static void PrintTree<T>(TreeNode<T> node, string indent = " ")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }
        public TreeNode<T> Find(T value)
        {
            return Root.Find(value);
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var companyTree = new Tree<string>("CEO");
            var finance = new TreeNode<string>("CFO");
            var tech = new TreeNode<string>("CTO");
            var marketing = new TreeNode<string>("CMO");


            companyTree.Root.AddChild(finance);
            companyTree.Root.AddChild(tech);
            companyTree.Root.AddChild(marketing);


            finance.AddChild(new TreeNode<string>("Accountant"));
            tech.AddChild(new TreeNode<string>("Developer"));
            tech.AddChild(new TreeNode<string>("UX Designer"));
            marketing.AddChild(new TreeNode<string>("Social Media Manager"));

            companyTree.PrintTree();

            Console.WriteLine("\nFinding Developer...");
            if (companyTree.Find("Developer") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.WriteLine("\nFinding DBA...");
            if (companyTree.Find("DBA") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.ReadKey();
        }
    }
}
