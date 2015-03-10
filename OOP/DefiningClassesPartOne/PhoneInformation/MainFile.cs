using System;

namespace PhoneInformation
{
    class MainFile
    {
        static void Main()
        {
            GSMTest tester = new GSMTest();
            tester.PrintPhones();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to run the call history test.");
            Console.WriteLine();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            GSMCallHistoryTest historyTester = new GSMCallHistoryTest();
            historyTester.TestPhone();
        }
    }
}