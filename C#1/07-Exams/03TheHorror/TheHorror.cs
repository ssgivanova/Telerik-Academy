using System;

class TheHorror
    {
        static void Main()
        {
            
            string input = Console.ReadLine();

            char[] text = input.ToCharArray();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if ((Char.IsDigit(symbol)) && (i % 2 == 0))
                {
                    //sum += symbol - '0';
                    sum += (int)Char.GetNumericValue(symbol);
                    count++;
                }
            }

            // For Nightmare on Code Street problem
            //count and calculate sum for odd positions
            /*
             * 
            int i =0;
            foreach (char symbol in text)
            {
                if (i % 2 == 1)
                {
                    switch (symbol)
                    {
                        case '0': counter++; break;
                        case '1': counter++; result += 1; break;
                        case '2': counter++; result += 2; break;
                        case '3': counter++; result += 3; break;
                        case '4': counter++; result += 4; break;
                        case '5': counter++; result += 5; break;
                        case '6': counter++; result += 6; break;
                        case '7': counter++; result += 7; break;
                        case '8': counter++; result += 8; break;
                        case '9': counter++; result += 9; break;
                    }
                }
                i++;
            }
            */
            Console.WriteLine("{0} {1}",count,sum);
        }
    }
