using System;
using System.Threading;
using System.Globalization;

class Decoding
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double encodedValue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                //Console.WriteLine("{0} - {1}",symbol,(int)symbol);

                if (symbol == '@')
                {
                    break;
                }
                else if (Char.IsLetter(symbol))
                {
                    encodedValue = ((int)symbol * salt) + 1000;
                }
                else if (Char.IsDigit(symbol))
                {
                    encodedValue = (int)symbol + salt + 500;
                }
                else
                {
                    encodedValue = (int)symbol - salt;
                }

                if (i % 2 == 0)
                {
                    encodedValue /= 100;
                    Console.WriteLine("{0:f2}", encodedValue);
                }
                else
                {
                    encodedValue *= 100;
                    Console.WriteLine("{0}", encodedValue);
                }
            }
        }
    }
