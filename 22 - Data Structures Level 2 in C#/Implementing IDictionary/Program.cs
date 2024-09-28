using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_IDictionary
{

    public class SimpleDictionary<TKey,TValue> : IDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _List = new List<KeyValuePair<TKey, TValue>>();

        // IEnumerable<T>

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _List.GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ICollection<T>

        public int Count => _List.Count;

        public bool IsReadOnly => false;

        public void Add(TKey key,TValue value)
        {
            foreach (var kvp in _List)
            {
                if (Equals(kvp.Key,key))
                {
                    throw new ArgumentException("An element with the same key already exists.");
                }
            }
            _List.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey,TValue> item) => Add(item.Key, item.Value);
       
        public void Clear() => _List.Clear();
       
        public bool Remove(TKey key)
        {
            for(int i=0;i<_List.Count;i++)
            {
                if (Equals(_List[i].Key, key))
                {
                    _List.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool Remove(KeyValuePair<TKey, TValue> item) => _List.Remove(item);
       
        public void CopyTo(KeyValuePair<TKey,TValue> [] array, int arrayIndex) => _List.CopyTo(array, arrayIndex);

        public bool Contains(KeyValuePair<TKey, TValue> item)=> _List.Contains(item);

        // IDictionary<TKey, TValue>
        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach (var kvp in _List)
            {
                if (Equals(kvp.Key, key))
                {
                    value = kvp.Value;
                    return true;
                }
            }
            value = default;
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            foreach(var kvp in _List)
            {
                if (Equals(kvp.Key, key))
                    return true;
            }
            return false;
        }

        public ICollection<TKey> Keys => _List.ConvertAll(kvp => kvp.Key);

        public ICollection<TValue> Values => _List.ConvertAll(kvp => kvp.Value);

        public TValue this[TKey key]
        {
            get
            {
                foreach (var kvp in _List)
                {
                    if (Equals(kvp.Key, key))
                    {
                        return kvp.Value;
                    }
                }
                throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
            }
            set
            {
                bool found = false;
                for (int i = 0; i < _List.Count; i++)
                {
                    if (Equals(_List[i].Key, key))
                    {
                        _List[i] = new KeyValuePair<TKey, TValue>(key, value);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    _List.Add(new KeyValuePair<TKey, TValue>(key, value));
                }
            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SimpleDictionary
            var myDictionary = new SimpleDictionary<int, string>();


            // Adding elements to the dictionary
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");


            // Accessing an element by key
            Console.WriteLine($"Element with key 2: {myDictionary[2]}");


            // Updating an element by key
            myDictionary[2] = "Two Updated";
            Console.WriteLine($"Updated element with key 2: {myDictionary[2]}");


            // Iterating over the dictionary
            Console.WriteLine("\nIterating over the dictionary:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            // Demonstrate the ContainsKey and Remove functionality
            if (myDictionary.ContainsKey(3))
            {
                Console.WriteLine("\nContains key 3, removing...");
                myDictionary.Remove(3);
            }

            // Display the dictionary after removal
            Console.WriteLine("\nDictionary after removing key 3:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
