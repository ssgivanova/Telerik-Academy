using System;

//Find online more information about ASCII (American Standard Code for 
//Information Interchange) and write a program that prints the visible 
//characters of the ASCII table on the console 
//(characters from  33  to  126  including).

//output : The  94  characters on single line


class PrintAsciiTable
{
        static void Main()
        {
            int start = 33;
            int end = 127; 
            for (int i = start; i < end; i++)
            {
                Console.Write((char)i);
            }
        }
}