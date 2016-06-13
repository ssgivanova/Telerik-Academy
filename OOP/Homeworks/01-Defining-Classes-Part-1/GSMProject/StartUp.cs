namespace GSMProject
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            GSMTest gsmTest = new GSMTest();
            gsmTest.ExecuteTest();

            CallTest callTest = new CallTest();
            callTest.ExecuteTest();
        }
    }
}
