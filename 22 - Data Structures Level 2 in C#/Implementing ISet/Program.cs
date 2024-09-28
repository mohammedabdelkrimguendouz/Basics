using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_ISet
{
    public class SimpleSet<T> : ISet<T>
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

        public void Add(T Item)
        {
            bool IsFound = false;

            foreach(T item in _Items)
            {
                if(Equals(item, Item))
                {
                    IsFound = true;
                    break;
                }
                    
            }
            if(!IsFound)
                 _Items.Add(Item);
        }
        public void Clear() => _Items.Clear();
        
        public bool Remove(T Item) => _Items.Remove(Item);
        
        public void CopyTo(T[] array, int arrayIndex) => _Items.CopyTo(array, arrayIndex);
       
        public bool Contains(T Item)=> _Items.Contains(Item);

        // ISet<T>
        public bool SetEquals(SimpleSet<T> values)
        {

           return  _Items.Equals(values);

            //if (values.Count != _Items.Count)
            //    return false;

            //foreach(var (item,value) in _Items.Zip(values,(first,second)=>(first,second)))
            //{
            //   if(!item.Equals(values))
            //        return false;
            //}
            //return true;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
