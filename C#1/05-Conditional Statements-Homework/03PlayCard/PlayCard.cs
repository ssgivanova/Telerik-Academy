using System;

//Classical play cards use the following signs to designate the card face:  
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A . 
//Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign 
//or "no CONTENT_OF_STRING" otherwise.

//Input
//•On the only line you will receive a single string.

//Output
//•Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".

//Constraints
//•String length will always be between 1 and 5


class PlayCard
    {
        static void Main()
        {
            string input = Console.ReadLine();

            bool isValid = false;

            if (input.Equals("J") || input.Equals("Q") || input.Equals("A") || input.Equals("K")
                || input.Equals("2") || input.Equals("3") || input.Equals("4") || input.Equals("5")
                || input.Equals("6") || input.Equals("7") || input.Equals("8") || input.Equals("9") 
                || input.Equals("10"))
            {
                isValid = true;
            }

            if (isValid)
            {
                Console.WriteLine("yes {0}", input);
            }
            else
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
