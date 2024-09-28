using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_IList
{

    public class SimpleList<T> : IList<T>
    {
        private List<T> _Items = new List<T>();

        // IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _Items.Count; i++)
            {
                yield return _Items[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ICollection<T>
        public int Count => _Items.Count;

        public bool IsReadOnly => false;

       
        public void Add(T Item) => _Items.Add(Item);
       
        public void Clear() => _Items.Clear();

        public bool Remove(T Item) =>  _Items.Remove(Item);
        public void CopyTo(T[] array, int arrayIndex) => _Items.CopyTo(array, arrayIndex);
        public bool Contains(T Item) => _Items.Contains(Item);
       

        // IList<T>

        public void RemoveAt(int index) => _Items.RemoveAt(index);
       
        public void Insert(int index, T Item) => _Items.Insert(index, Item);
       
        public int IndexOf(T Item) => _Items.IndexOf(Item);
    
        public T this[int index]
        {
            get => _Items[index];
            set => _Items[index] = value;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            SimpleList<string> myList = new SimpleList<string>();
            myList.Add("First");
            myList.Add("Second");
            myList.Insert(1, "Inserted");


            Console.WriteLine("List after adding and inserting:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }


            myList.RemoveAt(1); // Removes "Inserted"
            myList[0] = "Updated First"; // Update the first item


            Console.WriteLine("\nList after removing and updating:");
            for (int i=0;i< myList.Count;i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadKey();
        }
    }
}
