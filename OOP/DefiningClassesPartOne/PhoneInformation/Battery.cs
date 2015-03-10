using System;

namespace PhoneInformation
{
    public class Battery
    {
        private string model;
        private int? hoursTalked;
        private int? hoursIdle;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.model = model;
        }
        
        public Battery(string model, int? hoursTalked, int? hoursIdle, BatteryType batteryType)
            : this(model)
        {
            this.hoursTalked = hoursTalked;
            this.hoursIdle = hoursIdle;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get 
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("There is no battery model.");
                }
                return this.model; 
            }
        }
        public int? HoursTalked
        {
            get 
            {
                if (this.hoursTalked == null)
                {
                    throw new ArgumentNullException("Hours talked not set.");
                }
                return this.hoursTalked; 
            }
        }
        public int? HoursIdle
        {
            get 
            {
                if (this.hoursIdle == null)
                {
                    throw new ArgumentNullException("Hours idle not set.");
                }
                return this.hoursIdle; 
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                if (this.batteryType == null)
                {
                    throw new ArgumentNullException("There is no battery type.");
                }
                return this.batteryType;
            }
        }
    }
}