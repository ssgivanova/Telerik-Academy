using System;

//Declare two integer variables  a  and  b  and assign them with  5  and  10  
//and after that exchange their values by using some programming logic. 
//Print the variable values before and after the exchange.

class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Values before exchange : a={0}, b={1}",a,b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Values after exchange : a={0}, b={1}", a, b);

        }
}
