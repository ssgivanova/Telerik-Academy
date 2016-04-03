using System;
using System.Globalization;
using System.Threading;

//Write a program that safely compares two floating-point numbers (double) 
//with precision  eps = 0.000001 .

//Note: Two floating-point numbers  a  and  b  cannot be compared directly by
//a == b  because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to 
//each other than a fixed constant  eps .

//input :
//•On the first line you will receive the first floating-point number
//•On the second line you will receive the second floating-point number
//output - true or false

class ComparingFloats
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            float eps = 0.000001f;
            bool isEqual = false;

            if (Math.Abs(a - b) <= eps)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
            //Console.WriteLine("Difference = {0}", Math.Abs(a-b));
        }
}
