namespace GenericClass
{
    using System;

    class Init
    {
        static void Main()
        {
            GenericList<int> newList = new GenericList<int>();

            newList.AddElement(1);
            newList.AddElement(2);
            newList.AddElement(35);
            newList.AddElement(543);

            newList.InsertAt(5, 1);
            newList.RemoveAt(3);

            Console.WriteLine("List: " + newList.ToString());
            Console.WriteLine("Min: " + newList.Min());
            Console.WriteLine("Max: " + newList.Max());
            Console.WriteLine("Pos of 543 (starting from 0): " + newList.SearchByValue(543));
            
            newList.ClearList();
        }
    }
}