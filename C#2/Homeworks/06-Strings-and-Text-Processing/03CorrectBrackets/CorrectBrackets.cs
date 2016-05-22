/*
Write a program to check if in a given expression the  (  and  )  brackets are put correctly.

Input
•On the only line you will receive an expression

Output
•Print  Correct  if the brackets are correct ◦ Incorrect  otherwise


Constraints
•1 <= length of expression <= 10000
•Time limit: 0.1s
•Memory limit: 16MB
 * 
((a+b)/5-d) Correct 
)(a+b))     Incorrect 

 */

using System;
class CorrectBrackets
{
    static void Main()
    {

        //((a+b)/5-d) Correct 
        //)(a+b)) Incorrect 

        string expression = Console.ReadLine();

        bool isCorrect = true;
        int countOpeningBrackets = 0;
        int countClosingBrackets = 0;

        //count brackets
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countOpeningBrackets++;
            }

            if (expression[i] == ')')
            {
                countClosingBrackets++;
            }
        }

        if (countOpeningBrackets == countClosingBrackets)
        {
            //check if the order of the brackets is correct
            int indexOpeningBracket = expression.IndexOf("(");
            int indexClosingBracket = expression.IndexOf(")");

            while (indexOpeningBracket != -1 && indexClosingBracket != -1)
            {
                //the (must be before the ) to be correct
                if (indexOpeningBracket < indexClosingBracket)
                {
                    indexOpeningBracket = expression.IndexOf("(", indexOpeningBracket + 1);
                    indexClosingBracket = expression.IndexOf(")", indexClosingBracket + 1);
                }
                else //if ) is before (
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        else // different count of opening and closing brackets
        {
            isCorrect = false;
        }

        //Console.WriteLine("opening :" + countOpeningBrackets);
        //Console.WriteLine("closing :" + countClosingBrackets);

        //output
        if (isCorrect)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
        


        
    }

    static string GetContentOfBrackets(string str)
    {
        int countOpeningBrackets = 0;
        int countClosingBrackets = 0;
        string content = "";

        //if the expression starts with )
        if (str[0] == ')')
        {
            content = null; //incorrect expression
        }
        else
        {
            int indexOpening = str.IndexOf("(");
            int indexClosing = str.LastIndexOf(")");
            //Console.WriteLine("first ( "+indexOpening);
            //Console.WriteLine("last ) "+ indexClosing);

            if (indexOpening >= 0)
            {
                countOpeningBrackets++;
            }

            if (indexClosing > 0)
            {
                countClosingBrackets++;
            }
            if (indexOpening >= 0 && indexClosing > 0)
            {
                int lengthContent = str.Length - 2;
                content = str.Substring(indexOpening + 1, lengthContent);
                Console.WriteLine("inner :" + content);

            }
        }
        return content;
    }
}
