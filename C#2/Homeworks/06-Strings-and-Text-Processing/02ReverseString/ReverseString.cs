/*
•Write a program that reads a string, reverses it and prints the result on the console.

Input
•On the only line you will receive a string

Output
•Print the string in reverse on a single line

Constraints
•1 <= size of string <= 10000
•Time limit: 0.1s
•Memory limit: 16MB
 */
using System;
using System.Text;
class ReverseString
{
    static void Main()
     {
         string input = Console.ReadLine();
         string reversed = ReversingString(input);
         //string reversed = ReversingStringBuilder(input);

         Console.WriteLine(reversed);

     }

    static string ReversingString(string str)
    {
        string reversed = "";
        for (int i = str.Length -1;  i >=0;  i--)
        {
            reversed += str[i];
        }
        return reversed;
    }

    static string ReversingStringBuilder(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
}
