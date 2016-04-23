using System;

class OnesAndZeros
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int numberBits = 16;
            string number = Convert.ToString(n, 2).PadLeft(numberBits, '0');
            Console.WriteLine(number);

            //if the number is too big example maxInt - start with 1 and there's more bits than 16
            //2147483647 - > 1111111111111111111111111111111
            //remove the first bits and leave only the last 16
            if (number.Length > 16)
            {
                number = number.Substring(number.Length - 16, numberBits);
            }
            Console.WriteLine(number);

            int rows = 5;
            string result = "";
            string dot = ".";

            //for the 5 rows
            for (int i = 0; i < rows; i++)
            {
                string line = "";
                int k = 0; // count each bit - for not add "." after the last bit
                foreach (char bit in number)
                {
                    //print pattern for 1
                    if (bit == '1')
                    {
                        switch (i)
                        {
                            case 0: line = ".#."; break;
                            case 1: line = "##."; break;
                            case 2:
                            case 3: line = ".#."; break;
                            case 4: line = "###"; break;
                        }
                    }
                    //print pattern for 0
                    else if (bit == '0')
                    {
                        switch (i)
                        {
                            case 0:
                            case 4: line = "###"; break;
                            case 1:
                            case 2:
                            case 3: line = "#.#"; break;
                        }
                    }
                    result += line;
                    if (k < numberBits - 1)
                    {
                        result += dot;
                    }
                    k++;
                }
                //pass to the next line
                result += "\n";
            }            
            Console.WriteLine(result);            
        }
}
