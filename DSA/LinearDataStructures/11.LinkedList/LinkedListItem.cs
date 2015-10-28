namespace LinkedList
{
    public class LinkedListItem<T>
    {
        public LinkedListItem(T value)
        {
            this.Value = value;
            this.NextItem = null;
        }

        public T Value { get; set; }
        public LinkedListItem<T> NextItem { get; set; }
    }
}