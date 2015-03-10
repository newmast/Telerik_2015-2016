using System;

namespace PhoneInformation
{
    class Display
    {
        private float screenSize;
        private ulong numberOfColors;

        public Display(float screenSize, ulong numberOfColors)
        {
            this.screenSize = screenSize;
            this.numberOfColors = numberOfColors;
        }

        public float ScreenSize 
        { 
            get 
            {
                if (this.screenSize <= 0f)
                {
                    throw new ArgumentException("Invalid screen size.");
                }
                return this.screenSize; 
            } 
        }
        public ulong NumberOfColor
        {
            get 
            {
                if (this.numberOfColors <= 0)
                {
                    throw new ArgumentException("There are no colors.");
                }
                return this.numberOfColors; 
            }
        }
    }
}
