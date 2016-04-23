using System;
class SearchInBits
    {
        static void Main()
        {

            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());




            /* STRING SOLUTION
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string pattern = Convert.ToString(s, 2).PadLeft(4,'0');
            //Console.WriteLine(pattern);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(s, 2).PadLeft(30, '0');
                //Console.WriteLine(binary);

                if (binary.Contains(pattern))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
             * */
            /*
            const int NumberBits = 30;
            const int SearchBits = 4;

            int search = int.Parse(Console.ReadLine());
            //// string searchAsString = Convert.ToString(search, 2).PadLeft(SearchBits, '0'); // for debugging only
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                //// string numberAsString = Convert.ToString(number, 2).PadLeft(NumberBits, '0'); // for debugging only
                for (int startFromBit = NumberBits - 1; startFromBit >= SearchBits - 1; startFromBit--)
                {
                    bool found = true;
                    for (int searchBit = SearchBits - 1; searchBit >= 0; searchBit--)
                    {
                        int numberBit = startFromBit - (SearchBits - searchBit - 1);
                        int numberMask = 1 << numberBit;
                        int numberAndMask = number & numberMask;
                        int numberBitValue = numberAndMask >> numberBit;

                        int searchMask = 1 << searchBit;
                        int searchAndMask = search & searchMask;
                        int searchBitValue = searchAndMask >> searchBit;

                        if (numberBitValue != searchBitValue)
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);*/
        }
    }
