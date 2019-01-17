using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections.classes
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] items = new T[52];
        public int Counter { get; set; }


        public void AddCard(T input)
        {
            if (Counter > items.Length -1)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[Counter] = input;
            Count();
        }

        public void Remove()
        {
            Console.WriteLine("will figure out what to do later");
        }

        public void Count()
        {
            Counter++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Counter; i++)
            {
                yield return items[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
