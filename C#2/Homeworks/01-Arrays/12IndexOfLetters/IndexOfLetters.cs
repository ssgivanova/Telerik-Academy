using System;
/*
 Write a program that creates an array containing all letters from the alphabet ( a-z ). 
 Read a word from the console and print the index of each of its letters in the array.

Input
•On the first line you will receive the word

Output
•Print the index of each of the word's letters in the array 
◦Each index should be on a new line

Constraints
•1 <= word length <= 128
•Word is consisted of lowercase english letters
•Time limit: 0.1s
•Memory limit: 16MB
*/

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        //create alphabet array
        int nbrLetters = 26;
        char[] alphabet = new char[nbrLetters];

        char start = 'a';
        char end = 'z';
        
        for (int i = start; i <= end; i++)
        {
            int index = i - 'a'; // i- asci code of a (97) -> start from index = 0
            alphabet[index] = (char)i;
        }

        //print alphabet
        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    Console.Write(alphabet[i]+" ");
        //}

        for (int i = 0; i < word.Length; i++)
        {
            //get index ot each letter
            for (int j = 0; j < alphabet.Length; j++)
			{
                if (word[i] == alphabet[j])
                {
                    //Console.WriteLine("letter {0} - {1}", word[i], j);
                    Console.WriteLine(j);
                }
			}
        }
    }
}