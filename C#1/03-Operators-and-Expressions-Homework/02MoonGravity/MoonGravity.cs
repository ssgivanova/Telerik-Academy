using System;
using System.Threading;
using System.Globalization;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//•Write a program that calculates the weight of a man on the moon by a 
//given weight W(as a floating-point number) on the Earth.
//•The weight W should be read from the console.

//input : 
//The input will consist of a single line containing a single floating-point 
//number - the weight W.
//output : 
// a single floating-point value - how much a man with the weight W on Earth 
//will weigh on the Moon. Output all values with exactly 3-digit precision 
//after the floating point. 


class MoonGravity
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            float ratio = 0.17f;
            float weight = float.Parse(Console.ReadLine());
            float weightOnMoon = ratio * weight;

            Console.WriteLine("{0:f3}",weightOnMoon);

        }
}