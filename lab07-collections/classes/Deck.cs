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

        /// <summary>
        /// adds a card to the collection (at the end of the array), and will increase the array size as needed.
        /// </summary>
        /// <param name="input">object to add to the collection</param>
        public void AddCard(T input)
        {
            if (Counter == items.Length )
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[Counter] = input;
            Count();
        }

        /// <summary>
        /// removes an object from the collection
        /// </summary>
        /// <param name="removeItem">which object to remove</param>
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

        /// <summary>
        /// keeps count of how many objects are in the collection
        /// </summary>
        public void Count()
        {
            Counter++;
        }

        /// <summary>
        /// allows us to use FOREACH in our program
        /// </summary>
        /// <returns>the object in the collection</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Counter; i++)
            {
                yield return items[i];

            }
        }

        /// <summary>
        /// outdated function that calls GetEnumerator
        /// </summary>
        /// <returns>the new method</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
