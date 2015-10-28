namespace First50NumbersOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class NumbersOfSequence
    {
        static void Main()
        {
            PrintFirstMembersOfSequence(2, 50);
        }

        private static void PrintFirstMembersOfSequence(int number, int count)
        {
            var queue = new Queue<int>();

            var currentSequenceMember = number;
            for (int i = 1; i <= count; i++)
            {
                var memberToAdd = currentSequenceMember + 1;
                queue.Enqueue(memberToAdd);

                memberToAdd = 2 * currentSequenceMember + 1;
                queue.Enqueue(memberToAdd);

                memberToAdd = currentSequenceMember + 2;
                queue.Enqueue(memberToAdd);

                currentSequenceMember++;
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
