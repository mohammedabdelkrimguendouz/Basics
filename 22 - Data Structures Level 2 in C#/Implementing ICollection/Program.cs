using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_ICollection
{
    public class QueuLineCollection<T> : ICollection<T>
    {
        private Queue<T> Items=new Queue<T>();

        public int Count => Items.Count;

        public bool IsReadOnly => false;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Item in Items)
            {
                yield return Item;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T Item)
        {
            Items.Enqueue(Item);
        }
        public void Clear()
        {
            Items.Clear();
        }

        public bool Remove(T Item)
        {
             Queue<T> TempItems = new Queue<T>();
            try
            {
                if(!Items.Contains(Item))
                    return false;

                while (Items.Count > 0)
                {
                    T itm = Items.Dequeue();
                    if (itm.Equals(Item))
                        continue;

                    TempItems.Enqueue(itm);
                }

                
                Items = TempItems;
                //TempItems.Clear();
                return true;
            }
            catch
            {
                return false;
            }
            

        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public bool Contains(T Item)
        {
            return Items.Contains(Item);
        }
    }

    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> Items = new List<T>();

       // IEnumerable<T>
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                yield return Items[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ICollection<T>
   
        public int Count =>Items.Count;

        public bool IsReadOnly => false;

        
        public void Add(T Item)
        {
            Items.Add(Item);
        }
        public void Clear()
        {
            Items.Clear();
        }
        
        public bool Remove(T Item)
        {
           return Items.Remove(Item);
        }
        public void CopyTo(T[] array,int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public bool Contains(T Item)
        {
            return Items.Contains(Item);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------- SimpleCollection ----------------------------\n");

            SimpleCollection<string> shoppingCart = new SimpleCollection<string>();
            shoppingCart.Add("Apple");
            shoppingCart.Add("Banana");
            shoppingCart.Add("Carrot");


            Console.WriteLine($"Items in cart: {shoppingCart.Count}");

            if (shoppingCart.Contains("Banana"))
            {
                shoppingCart.Remove("Banana");
                Console.WriteLine("Banana removed from the cart.");
            }


            Console.WriteLine("Final items in the cart:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------- QueuLineCollection ----------------------------\n");
            QueuLineCollection<int> Line = new QueuLineCollection<int>();
            Line.Add(1);
            Line.Add(2);
            Line.Add(3);
            Line.Add(4);
            Line.Add(5);

            Console.WriteLine("All items in the Line:");
            foreach (var item in Line)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Items in Line: {Line.Count}");

            if (Line.Contains(3))
            {
                Line.Remove(3);
                Console.WriteLine("Number 3 removed from the Line.");
            }
            if (Line.Contains(1))
            {
                Line.Remove(1);
                Console.WriteLine("Number 1 removed from the Line.");
            }


            Console.WriteLine("Final items in the Line:");
            foreach (var item in Line)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
