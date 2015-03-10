using System;

namespace PhoneInformation
{
    class GSMCallHistoryTest
    {
        private GSM phone = new GSM("HTC Desire", "HTC");

        public void TestPhone()
        {
            AddCalls();
            DisplayCallInfo();
            Console.WriteLine("Total call price: " + phone.CalculateCallPrice(0.37f));
            RemoveLongestCall();
            Console.WriteLine("Longest call has been removed.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Press any key to print current call history.");
            Console.WriteLine();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            DisplayCallInfo();

            phone.ClearCallHistory();
            Console.WriteLine("Call history cleared!");

            DisplayCallInfo();
        }

        private void RemoveLongestCall()
        {
            int longestCallID = 0;
            for (int i = 0; i < phone.CallHistory.Count - 1; i++)
            {
                if (phone.CallHistory[i + 1].DurationInMinutes > phone.CallHistory[i].DurationInMinutes)
	            {
                    longestCallID = i;
	            }
            }
            phone.DeleteCall(phone.CallHistory[longestCallID]);
        }

        private void AddCalls()
        {
            phone.AddCalls(new Call("13/02/2014", "13:30", "+359870303212", 12));
            phone.AddCalls(new Call("10/01/2013", "17:43", "+359870303537", 6));
            phone.AddCalls(new Call("17/05/2014", "07:59", "+359870354321", 3));
        }
        private void DisplayCallInfo()
        {
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                Console.WriteLine("Date: " + phone.CallHistory[i].CallDate);
                Console.WriteLine("Time: " + phone.CallHistory[i].CallTime);
                Console.WriteLine("Dialed number: " + phone.CallHistory[i].DialedNumber);
                Console.WriteLine("Duration: {0} minutes.", phone.CallHistory[i].DurationInMinutes);
                Console.WriteLine();
            }
        }
    }
}
