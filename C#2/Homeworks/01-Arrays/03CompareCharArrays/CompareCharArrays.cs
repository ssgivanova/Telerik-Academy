using System;
/*
Write a program that compares two  char  arrays lexicographically (letter by letter).

Input
•On the first line you will receive the first  char  array as a string
•On the second line you will receive the second  char  array as a string

Output
•Print  <  if the first array is lexicographically smaller
•Print  >  if the second array is lexicographically smaller
•Print  =  if the arrays are equal

Constraints
•1 <= size of arrays <= 128
•Time limit: 0.1s
•Memory limit: 16MB

 * */
class CompareCharArrays
{
    static void Main()
    {
        char[] charArr1 = Console.ReadLine().ToCharArray();
        char[] charArr2 = Console.ReadLine().ToCharArray();

        //i assume they are equals in the beginning
        char comparison = '='; //<,>,=
        
        //has same length - they can be equal
        if (charArr1.Length == charArr2.Length)
        {
            for (int i = 0; i < charArr1.Length; i++)
            {
                if (charArr1[i] != charArr2[i])
                {
                    // the first array is lexicographically smaller
                    if (charArr1[i] < charArr2[i])
                    {
                        comparison = '<';
                    }
                    else if (charArr1[i] > charArr2[i])
                    {
                        //the second array is lexicographically smaller
                        comparison = '>';
                    }
                }
            }
        }
        else
        {
            //the 2 arrays has differents lengths -> find the smaller length
            int minLength = Math.Min(charArr1.Length, charArr2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (charArr1[i] != charArr2[i])
                {
                    // the first array is lexicographically smaller
                    if (charArr1[i] < charArr2[i])
                    {
                        comparison = '<';
                        break;
                    }
                    if (charArr2[i] < charArr1[i])
                    {
                        //the second array is lexicographically smaller
                        comparison = '>';
                        break;
                    }
                }
                else 
                {
                    // the first elements are equals but one of the 2 arrays has more elements
                    //-> the arrays with smaller length is lexicographically smaller
                    if (charArr1.Length < charArr2.Length)
                    {
                        comparison = '<';
                    }
                    else
                    {
                        comparison = '>';
                    }
                }
            }
        }
        Console.WriteLine(comparison);
    }
}
