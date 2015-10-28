namespace Stack
{
    using System;

    public class Stack<T> 
    {
        private const int InitialStackSize = 4;
        private const string StackEmptyExceptionMessage = "Cannot pop. Stack is empty!";
        private T[] elements;
        private int top;

        public Stack()
        {
            this.elements = new T[InitialStackSize];
            this.top = 0;
        }

        public void Push(params T[] values)
        {
            foreach (var value in values)
            {
                if (IsFull())
                {
                    var biggerElements = new T[this.elements.Length*2];

                    for (int i = 0; i < this.elements.Length; i++)
                    {
                        biggerElements[i] = this.elements[i];
                    }

                    this.elements = biggerElements;
                }

                this.elements[this.top++] = value;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new ArgumentException(StackEmptyExceptionMessage);
            }

            return this.elements[--this.top];
        }

        private bool IsFull()
        {
            return this.elements.Length == this.top;
        }

        private bool IsEmpty()
        {
            return this.top == 0;
        }

        public int Length
        {
            get { return this.top; }
        }
    }
}