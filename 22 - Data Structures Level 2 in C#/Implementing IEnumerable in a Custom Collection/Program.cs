using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Implementing_IEnumerable_in_a_Custom_Collection
{
    
    internal class Program
    {
        public class CustomCollection<T> : IEnumerable<T>
        {
            private List<T> Items = new List<T>();

            // IEnumerable<T>
            public IEnumerator<T> GetEnumerator()
            {
                for(int i =0; i < Items.Count;i++)
                {
                    yield return Items[i];
                }

            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            public void Add(T Item)
            {
                Items.Add(Item);
            }

        }
        static void Main(string[] args)
        {
            CustomCollection<int> myCollection = new CustomCollection<int>() {10,11,12};
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);



            foreach (int item in myCollection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
