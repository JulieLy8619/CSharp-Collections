using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections.classes
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] items = new T[52];
        int currInd = 0;
        public void AddCard(T input)
        {
            if (currInd > items.Length -1)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[currInd] = input;
            currInd++;
        }

        public void Remove()
        {
            Console.WriteLine("will figure out what to do later");
        }

        public void Count()
        {
            Console.WriteLine("will figure out what to do later");
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currInd; i++)
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
