using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInformation
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private ulong? price; // we are dealing with an iPhone here
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        private static GSM iPhone4S = new GSM("4S", "Apple", 700000, "Billy", 
                                      new Battery("Duracell", 20000, 1, BatteryType.Li_Ion), 
                                      new Display(5, 16000000));

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, ulong? price, string owner)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, ulong? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get 
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("There is no model.");
                }
                return this.model; 
            }
        }
        public string Manufacturer
        {
            get 
            {
                if (this.manufacturer == string.Empty)
                {
                    throw new ArgumentNullException("There is no manufacturer.");
                }
                return this.manufacturer; 
            }
        }
        public ulong? Price
        {
            get 
            {
                if (this.price == null)
                {
                    throw new ArgumentNullException("There is no price!");
                }
                return this.price; 
            }
        }
        public string Owner
        {
            get 
            {
                if (this.owner == string.Empty)
                {
                    throw new ArgumentNullException("There is no string.");
                }
                return this.owner; 
            }
        }
        public Battery Battery
        {
            get 
            {
                if (this.battery == null)
                {
                    throw new ArgumentNullException("There is no battery.");
                }
                return this.battery; 
            }
        }
        public Display Display
        {
            get 
            {
                if (this.display == null)
                {
                    throw new ArgumentNullException("There is no display.");
                }
                return this.display; 
            }
        }
        public static GSM IPhone4S
        {
            get
            {
                if (iPhone4S == null)
                {
                    throw new ArgumentNullException("No iPhone 4S!");
                }
                return iPhone4S;
            }
        }
        public override string ToString()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("Phone characteristics:");
            information.AppendLine("Model: " + this.model);
            information.AppendLine("Manufacturer: " + this.manufacturer);
            information.AppendLine("Price: " + this.price);
            information.AppendLine("Owner: " + this.owner);
            information.AppendLine("Battery: " + this.battery.Model);
            information.AppendLine("Display: " + this.display.ScreenSize);

            return information.ToString();
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public float CalculateCallPrice(float pricePerMinute)
        {
            float price = 0;

            uint totalTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime += callHistory[i].DurationInMinutes;
            }

            price = pricePerMinute * totalTime;

            return price;
        }
    }
}