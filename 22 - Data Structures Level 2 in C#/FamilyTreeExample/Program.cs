using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeExample
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> Child) => Children.Add(Child);
    }

    public class Person
    {
        public string Name { get; set; }
        // Other properties like age, gender, etc.

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        public static void PrintFamilyTree(TreeNode<Person> node, string indent = "")
        {
            Console.WriteLine(indent + node.Value.Name);

            foreach (var child in node.Children)
            {
                PrintFamilyTree(child, indent + "  ");
            }
        }
        static void Main(string[] args)
        {
            TreeNode<Person> root = new TreeNode<Person>(new Person("John"));
            TreeNode<Person> child1 = new TreeNode<Person>(new Person("Alice"));
            TreeNode<Person> child2 = new TreeNode<Person>(new Person("Bob"));
            TreeNode<Person> child3 = new TreeNode<Person>(new Person("Carol"));
            TreeNode<Person> child4 = new TreeNode<Person>(new Person("Semon"));

            TreeNode<Person> grandchild1 = new TreeNode<Person>(new Person("David"));
            TreeNode<Person> grandchild2 = new TreeNode<Person>(new Person("Emily"));

            TreeNode<Person> grandchild3 = new TreeNode<Person>(new Person("Jasmin"));
            TreeNode<Person> grandchild4 = new TreeNode<Person>(new Person("Tom"));

            TreeNode<Person> grandchild5 = new TreeNode<Person>(new Person("Roy"));

            TreeNode<Person> GrandGrandChild1 = new TreeNode<Person>(new Person("Zaina"));

            child1.AddChild(grandchild1);
            child1.AddChild(grandchild2);

            child2.AddChild(grandchild3);
            child2.AddChild(grandchild4);

            child3.AddChild(grandchild5);

            grandchild3.AddChild(GrandGrandChild1);

            root.AddChild(child1);
            root.AddChild(child2);
            root.AddChild(child3);
            root.AddChild(child4);

            PrintFamilyTree(root);
            Console.ReadKey();
        }
    }
}
