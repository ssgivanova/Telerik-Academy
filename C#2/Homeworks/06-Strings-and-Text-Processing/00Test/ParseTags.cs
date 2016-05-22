using System;
using System.Text;
class ParseTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder temp = new StringBuilder();
            StringBuilder output = new StringBuilder();
            int indexOfStart = -1;
            int indexOfEnd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                temp.Clear();
                if (i == input.IndexOf("<upcase>", indexOfEnd))
                {
                    indexOfStart = input.IndexOf("<upcase>", indexOfEnd);
                    indexOfEnd = input.IndexOf("</upcase>", indexOfStart);
                    if (indexOfStart != -1)
                    {
                        do
                        {
                            temp.Append(input[indexOfStart + 8]);
                            indexOfStart++;
                        } while (indexOfStart < indexOfEnd - 8);
                        output.Append(temp.ToString().ToUpper());
                    }
                    i = indexOfEnd + 8;
                }
                else
                {
                    output.Append(input[i]);
                }
            }

            Console.WriteLine(output.ToString());

        }
}
