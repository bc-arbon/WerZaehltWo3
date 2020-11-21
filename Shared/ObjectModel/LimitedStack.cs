namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    using System;

    /// <summary>
    /// LimitedStack class
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    public class LimitedStack<T> where T : class
    {
        /// <summary>
        /// The stack
        /// </summary>
        private T[] stack;

        /// <summary>
        /// The capacity of the stack
        /// </summary>
        private int capacity = -1;

        /// <summary>
        /// The current stack item 
        /// </summary>
        private int current = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedStack&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="newCapacity">The new capacity.</param>
        public LimitedStack(int newCapacity)
        {
            if (newCapacity <= 0) throw new ArgumentOutOfRangeException("newCapacity", @"Capacity must be greater zero.");

            this.capacity = newCapacity;
            this.Clear();
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public T[] Items
        {
            get { return this.stack; }
            set { this.stack = value; }
        }

        /// <summary>
        /// Gets the current count of items.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get
            {
                return this.current + 1;
            }
        }

        /// <summary>
        /// Gets or sets the capacity. Stack will be cleared after setting capacity.
        /// </summary>
        /// <value>The capacity.</value>
        public int Capacity
        {
            get
            {
                return this.stack.Length;
            }

            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("value", @"Capacity must be greater zero.");

                this.capacity = value;
                this.Clear();
            }
        }

        /// <summary>
        /// Clears the stack.
        /// </summary>
        public void Clear()
        {
            this.stack = new T[this.capacity];
            this.current = -1;
        }

        /// <summary>
        /// Removes and returns the item at the top.    
        /// </summary>
        /// <returns>The item</returns>
        public T Pop()
        {
            if (this.Count == 0) throw new InvalidOperationException("Stack is empty. Push an item before calling pop.");

            var result = this.stack[this.current];
            this.stack[this.current] = default(T);
            this.current--;

            return result;
        }

        /// <summary>
        /// Inserts an item at the top.
        /// </summary>
        /// <param name="newItem">The new item.</param>
        public void Push(T newItem)
        {
            if (this.current + 1 == this.capacity)
            {
                for (var i = 1; i < this.capacity; i++)
                {
                    this.stack[i - 1] = this.stack[i];
                }
            }
            else
            {
                this.current++;
            }

            this.stack[this.current] = newItem;
        }
    }
}