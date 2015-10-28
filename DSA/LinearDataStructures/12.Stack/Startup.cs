namespace Stack
{
    using System;

    public class Startup
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1, 2, 3, 4, 5);

            while (stack.Length > 0)
            {
                Console.Write(stack.Pop() + (stack.Length != 0 ? " -> " : string.Empty));
            }

            Console.WriteLine();
        }
    }
}
