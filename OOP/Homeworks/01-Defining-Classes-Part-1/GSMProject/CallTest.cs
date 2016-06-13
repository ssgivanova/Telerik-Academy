namespace GSMProject
{
    using System;
    using System.Collections.Generic;

    /*
    Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    Create an instance of the GSM class.
    Add few calls.
    Display the information about the calls.
    Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    Remove the longest call from the history and calculate the total price again.
    Finally clear the call history and print it.
     */

    class CallTest
    {
        private const decimal PRICE_PER_MIN = 0.37m;
        private GSM myGsm = new GSM("S3Neo", "Samsung");

        public void ExecuteTest()
        {
            //call tests
            Call call1 = new Call("0887123456", 60, new DateTime(2016, 6, 13, 10, 20, 55));
            Call call2 = new Call("0888997600", 25, new DateTime(2016, 6, 12, 8, 33, 05));
            Call call3 = new Call("0886123256", 110, new DateTime(2016, 5, 30, 21, 10, 15));
            Call call4 = new Call("0888976432", 45, new DateTime(2016, 6, 1, 23, 30, 17));
            Call call5 = new Call("0888112233", 240, new DateTime(2016, 4, 20, 17, 45, 48));

            myGsm.AddCall(call1);
            myGsm.AddCall(call2);
            myGsm.AddCall(call3);
            myGsm.AddCall(call4);
            myGsm.AddCall(call5);

            List<Call> myCalls = myGsm.CallHistory;
            myGsm.PrintCallHistoryInfo();

            decimal totalPrice = myGsm.CalculateTotalCallPrice(PRICE_PER_MIN);
            Console.WriteLine("Total call price : {0}lv ", totalPrice);

            //Remove the longest call from the history and calculate the total price again.
            int maxDuration = 0;
            Call longestCall = myCalls[0];

            for (int i = 0; i < myCalls.Count; i++)
            {
                Call currentCall = myCalls[i];
                if (currentCall.Duration > maxDuration)
                {
                    maxDuration = currentCall.Duration;
                    longestCall = currentCall;
                }
            }
            Console.WriteLine("Longest call : {0}s", longestCall.Duration);
            myGsm.DeleteCall(longestCall);

            totalPrice = myGsm.CalculateTotalCallPrice(0.37m);
            Console.WriteLine("Total call price after removing the longest call : {0}lv ", totalPrice);


            //Finally clear the call history and print it.
            myGsm.ClearCallHistory();
            myGsm.PrintCallHistoryInfo();
        }
    }

    
}
