using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timer
{
    public delegate void Timer(int time);

    class Init
    {
        static void Main()
        {
            Timer timer = delegate(int t)
            {
                while (true)
                {
                    Thread.Sleep(t);
                    Console.WriteLine("Text that appears every " + t + " miliseconds.");
                }
            };

            Console.Write("Enter time interval: ");
            int time = int.Parse(Console.ReadLine());

            timer(time);
        }
    }
}