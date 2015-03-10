using System;

namespace PhoneInformation
{
    class GSMTest
    {
        private GSM[] phones = 
        {
        new GSM("3310", "Nokia", 0, "everyone",
            new Battery("DuracellMEGA", 100, 2000, BatteryType.NiCd),
            new Display(0.5f, 4))
        , 
        new GSM("g3", "LG", 750, "pesho",
            new Battery("DuracellPRO", 200, 4000, BatteryType.NiMH),
            new Display(5f, 16000000)) 
        };

        public void PrintPhones()
        {
            Console.WriteLine(phones[0].ToString());
            Console.WriteLine(phones[1].ToString());
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
