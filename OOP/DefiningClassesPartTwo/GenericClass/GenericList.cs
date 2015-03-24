using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    public class GenericList<T> where T : IComparable
    {
        private int currentIndex;
        private int size;
        public T[] ElementList { get; set; }

        public GenericList()
        {
            this.size = 1;
            this.ElementList = new T[size];
            this.currentIndex = 0;
        }
        public T Min()
        {
            T result = this.ElementList[0];

            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.ElementList[i].CompareTo(result) < 0)
                {
                    result = this.ElementList[i];
                }
            }

            return result;
        }
        public T Max()
        {
            T result = this.ElementList[0];

            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.ElementList[i].CompareTo(result) > 0)
                {
                    result = this.ElementList[i];
                }
            }

            return result;
        }
        public void AddElement(T element)
        {
            DoubleSize();
            this.ElementList[this.currentIndex] = element;
            this.currentIndex++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.ElementList.Length)
                {
                    throw new IndexOutOfRangeException("List index was out of range.");
                }
                return ElementList[index];
            }
            set
            {
                if (index < 0 || index >= this.ElementList.Length)
                {
                    throw new IndexOutOfRangeException("List index was out of range.");
                }
                ElementList[index] = value;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.ElementList.Length)
            {
                throw new IndexOutOfRangeException("List index was out of range.");
            }

            for (int i = index; i < this.ElementList.Length - 1; i++)
            {
                this.ElementList[i] = this.ElementList[i + 1];
            }
            this.currentIndex--;
        }
        public void InsertAt(T element, int index)
        {
            if (index < 0 || index >= this.ElementList.Length)
            {
                throw new IndexOutOfRangeException("List index was out of range.");
            }
            this.currentIndex++;

            for (int i = this.ElementList.Length - 1; i >= index + 1; i--)
            {
                this.ElementList[i] = this.ElementList[i - 1];
            }
            this.ElementList[index] = element;
        }
        public void ClearList()
        {
            this.currentIndex = 0;
            this.size = 0;
            this.ElementList = new T[1];
        }
        public int SearchByValue(T value)
        {
            for (int i = 0; i < this.ElementList.Length; i++)
			{
                if (this[i].CompareTo(value) == 0)
	            {
                    return i;
	            }
			}
            return -1;
        }

        private void DoubleSize()
        {
            if (this.currentIndex == this.size - 1)
            {
                this.size *= 2;
                T[] temp = new T[(this.size * 2 + 1)];
                for (int i = 0; i < this.ElementList.Length; i++)
                {
                    temp[i] = this.ElementList[i];
                }
                this.ElementList = temp;
            }
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();
            for (int i = 0; i < this.currentIndex; i++)
            {
                printer.Append(this.ElementList[i] + " ");
            }
            return printer.ToString();
        } 
    }
}