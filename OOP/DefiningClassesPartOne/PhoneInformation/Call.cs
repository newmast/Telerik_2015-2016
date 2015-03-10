using System;
using System.Text;

namespace PhoneInformation
{
    class Call
    {
        private string callDate;
        private string callTime;
        private string dialedNumber;
        private uint durationInMinutes;

        public Call(string callDate, string callTime, string dialedNumber, uint durationInMinutes)
        {
            this.callDate = callDate;
            this.callTime = callTime;
            this.dialedNumber = dialedNumber;
            this.durationInMinutes = durationInMinutes;
        }

        public string CallDate
        {
            get { return callDate; }
        }
        public string CallTime
        {
            get { return callTime; }
        }
        public string DialedNumber
        {
            get { return dialedNumber; }
        }
        public uint DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.AppendLine("Date: " + callDate);
            printer.AppendLine("Time: " + callTime);
            printer.AppendLine("Dialed number: " + dialedNumber);
            printer.AppendLine("Duration: " + durationInMinutes);

            return printer.ToString();
        }
    }
}