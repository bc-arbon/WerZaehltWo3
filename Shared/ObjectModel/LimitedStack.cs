using System;

namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    public class LimitedStack<T> where T : class
    {
        private int capacity = -1;
        private int current = -1;

        public LimitedStack(int newCapacity)
        {
            if (newCapacity <= 0) throw new ArgumentOutOfRangeException("newCapacity", @"Capacity must be greater zero.");

            this.capacity = newCapacity;
            this.Clear();
        }

        public T[] Items { get; set; }

        public int Count
        {
            get
            {
                return this.current + 1;
            }
        }

        public int Capacity
        {
            get
            {
                return this.Items.Length;
            }

            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("value", @"Capacity must be greater zero.");

                this.capacity = value;
                this.Clear();
            }
        }

        public void Clear()
        {
            this.Items = new T[this.capacity];
            this.current = -1;
        }

        public T Pop()
        {
            if (this.Count == 0) throw new InvalidOperationException("Stack is empty. Push an item before calling pop.");

            var result = this.Items[this.current];
            this.Items[this.current] = default;
            this.current--;

            return result;
        }

        public void Push(T newItem)
        {
            if (this.current + 1 == this.capacity)
            {
                for (var i = 1; i < this.capacity; i++)
                {
                    this.Items[i - 1] = this.Items[i];
                }
            }
            else
            {
                this.current++;
            }

            this.Items[this.current] = newItem;
        }
    }
}