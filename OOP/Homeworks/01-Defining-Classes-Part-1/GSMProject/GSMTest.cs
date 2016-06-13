namespace GSMProject
{
    using System;
    using System.Collections.Generic;

    //Write a class GSMTest to test the GSM class:
    //Create an array of few instances of the GSM class.
    //Display the information about the GSMs in the array.
    //Display the information about the static property IPhone4S.

    class GSMTest
    {
        public void ExecuteTest()
        {
            List<GSM> gsms = new List<GSM>();

            GSM gsm1 = new GSM("Samsung", "Galaxy S7", 1000, "Maria", 
                                new Battery(BatteryType.LiOn),
                                new Display(1440, 2560, 5.1)); 
            GSM gsm2 = new GSM("Samsung", "Galaxy A7",600,"Peter", 
                                new Battery(BatteryType.LiOn),
                                new Display(1080,1920 ,5.5));
            GSM gsm3 = new GSM("Apple", "iPhone 6s", 1000, "Martin",
                                new Battery(BatteryType.LiPo,"1715",240,14), 
                                new Display(750, 1334, 4.7));

            gsms.Add(gsm1);
            gsms.Add(gsm2);
            gsms.Add(gsm3);

            //print all gsm information
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
            }

            //Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
