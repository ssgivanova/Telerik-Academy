using System;

class TextToNumber
{
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToLower();

            long result = 0;
            int code = 0;
            int codeLetterA = 97;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (currentLetter == '@')
                {
                    break;
                }
                else if (Char.IsDigit(currentLetter))
                {
                    result *= (int)Char.GetNumericValue(currentLetter);
                }
                else if (Char.IsLetter(currentLetter))
                {
                    code = (int)currentLetter - codeLetterA;
                    result += code;
                }
                else
                {
                    result %= m;
                }
            }
            Console.WriteLine(result);

            //print letters code
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    int codeChar = (int)i - 97;
            //    Console.Write("{0} - > {1}\n", i, codeChar);
            //}
        }
}
