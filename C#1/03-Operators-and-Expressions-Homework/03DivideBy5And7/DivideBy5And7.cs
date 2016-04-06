using System;

//Write a program that does the following:
//•Reads an integer number from the console.
//•Stores in a variable if the number can be divided by 7 and 5 without remainder.
//•Prints on the console "true NUMBER" if the number is divisible without 
//remainder by 7 and 5. 
//Otherwise prints "false NUMBER". 
//In place of NUMBER print the value of the input number. 


    class DivideBy5And7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool divisibleBy5And7 = false;

            if(n % 7 == 0 && n % 5 == 0)
            {
                divisibleBy5And7 = true;
            }
            Console.WriteLine("{0} {1}", divisibleBy5And7.ToString().ToLower(), n);
        }
    }
