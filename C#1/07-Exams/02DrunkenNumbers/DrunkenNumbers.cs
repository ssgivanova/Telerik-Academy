using System;
class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumMitko = 0; //left digits
        int sumVladko = 0; //right digits
        int totalSum = 0;
        int difference = 0;

        char winner = '\0';
        int max = 0;

        // FIRST SOLUTION - WITH STRINGS

        for (int i = 0; i < n; i++)
        {
            //if the num starts with 0 - remove the leading zeros when parsing it to int
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                number = Math.Abs(number);
            }

            string num = number.ToString();
            
            int digit = 0;

            int middleDigit = num[num.Length / 2] - '0';

            //even number digits
            //left digits - mitko
            for (int k = 0; k < num.Length / 2; k++)
            {
                digit = num[k] - '0';
                sumMitko += digit;
            }

            //right digits - vladko
            for (int k = num.Length / 2; k < num.Length; k++)
            {
                digit = num[k] - '0';
                sumVladko += digit;
            }
            // odd number digits
            if (num.Length % 2 != 0)
            {
                sumMitko += middleDigit;
            }
            
            //Console.WriteLine("mitko - sum {0}",sumMitko);
            //Console.WriteLine("vladko - sum {0}", sumVladko);

            difference = Math.Abs(sumVladko - sumMitko);
            totalSum = sumMitko + sumVladko;
        }
        if (sumMitko == sumVladko)
        {
            Console.WriteLine("No {0}", totalSum);
        }
        else
        {
            if (sumMitko > max)
            {
                max = sumMitko; winner = 'M';
            }
            if (sumVladko > max)
            {
                max = sumVladko; winner = 'V';
            }
            Console.WriteLine("{0} {1}", winner, difference);
        }

        /* SECOND SOLUTION - WITH REMAINDER OF DIVISION

        int n = int.Parse(Console.ReadLine());

        // Vladko beers
        int rightDigitsSum = 0;

        // Mitko beers
        int leftDigitsSum = 0;

        for (int i = 0; i < n; i++)
        {
            // Read the number, skipping the leading zeroes
            int currentNumber = int.Parse(Console.ReadLine());

            // Turn negative numbers to positive (remove the "-" sign)
            if (currentNumber < 0)
            {
                currentNumber *= -1;
            }

            // Calculate the total number of digits
            int numberOfDigits = 0;
            int num = currentNumber;
            while (num != 0)
            {
                num = num / 10;
                numberOfDigits++;
            }

            // Sum of digits at the right side
            for (int right = 0; right < numberOfDigits / 2; right++)
            {
                int currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                rightDigitsSum += currentDigit;
            }

            if (numberOfDigits % 2 == 1)
            {
                // We have a middle digit --> add it to both sums
                int middleDigit = currentNumber % 10;
                leftDigitsSum += middleDigit;
                rightDigitsSum += middleDigit;
                currentNumber = currentNumber / 10;
            }

            // Sum of digits at the left side
            for (int left = 0; left < numberOfDigits / 2; left++)
            {
                int currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                leftDigitsSum += currentDigit;
            }
        }

        // Print the results: winner and difference
        int difference = leftDigitsSum - rightDigitsSum;
        if (difference > 0)
        {
            Console.WriteLine("M {0}", difference);
        }
        else if (difference < 0)
        {
            Console.WriteLine("V {0}", difference * -1);
        }
        else
        {
            Console.WriteLine("No {0}", rightDigitsSum + leftDigitsSum);
        }
         * */
    }
 }
