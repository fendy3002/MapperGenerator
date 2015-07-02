using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG.Common.Collection
{
    public class SafeDictionary<T, V>
    {
        public SafeDictionary(IDictionary<T, V> dictionary)
        {
            this.Dictionary = dictionary;
        }

        private IDictionary<T, V> dictionary;
        public IDictionary<T, V> Dictionary
        {
            get { return dictionary; }
            set { dictionary = value; }
        }

        public V Get(T key, V defaultValue)
        {
            V returnValue = default(V);
            if (Dictionary == null || key == null)
            {
                return defaultValue;
            }

            if (Dictionary.TryGetValue(key, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return defaultValue;
            }
        }

        public void Add(T key, V value)
        {
            V returnValue = default(V);
            if (Dictionary == null)
            {
                return;
            }

            if (Dictionary.TryGetValue(key, out returnValue))
            {
                Dictionary[key] = value;
            }
            else
            {
                Dictionary.Add(key, value);
            }
        }
    }
    public static class SafeDictionaryHelper
    {
        public static SafeDictionary<T, V> AsSafe<T, V>(this IDictionary<T, V> source)
        {
            return new SafeDictionary<T, V>(source);
        }
    }
}
