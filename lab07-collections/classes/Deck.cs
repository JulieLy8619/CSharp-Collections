using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections.classes
{
    public class Deck<T> : IEnumerable<T>
    {
        public T[] items = new T[52];
        public int Counter { get; set; }


        public void AddCard(T input)
        {
            if (Counter == items.Length )
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[Counter] = input;
            Count();
        }

        public void Remove(T removeItem)
        {
            //amanda said think of how we removed a word in lab 3
            T[] temp = new T[Counter - 1];
            int tempCounter = 0;
            foreach (T card in items)
            {
                if (card != null)
                {
                    if (!card.Equals(removeItem))
                    {
                        temp[tempCounter] = card;
                        tempCounter++;
                    }
                }
            }
            items = temp;
            Counter--;

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
