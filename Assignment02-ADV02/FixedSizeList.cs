using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_ADV02
{
    internal class FixedSizeList<T>
    {
        private T[]? items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater zero.");
            items = new T[capacity];
            count = 0;
        }

        public int Count => count;

        public int Capacity => items.Length;

        public void Add(T item)
        {
            if (count >= Capacity)
                throw new InvalidOperationException("List is full. Cannot add more elements.");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index. Index is out of range.");

            return items[index];
        }

    }
}
