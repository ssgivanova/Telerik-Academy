/*
Write a method  ReadNumber(int start, int end)  that enters an integer number in a given range  
( start, end ) .
•If an invalid number or non-number text is entered, the method should throw an exception. 
Using this method write a program that enters  10  numbers:  a1, a2, ..., a10 , 
such that  0 < a1 < ... < a10 < 100 

Input
•You will receive 10 lines of input, each consisted of an integer number ◦ a1 
◦ a2 
◦ ... 
◦ a10 

Output
Print  0 < a1 < ... < a10 < 100
Or  Exception  if the above inequality is not true

 * */

using System; // 80/100

class NotIncreasingException : Exception
{
    private string message;

    public NotIncreasingException()
    {
        //message = "Numbers are not increasing";

        //for the condition for bgcoder it has to print : Exception
        message = "Exception";
    }

    public override string Message
    {
        get { return message; }
    }
}

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;

        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            try
            {
                numbers[i] = ReadNumber(start, end);
            }
            //the method ReadNumber throw an exception, we have to catch it
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the specified range-[{0},{1}]", start, end);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("The entered number is not in the needed format.It must be integer number", fe);
            }
        }

        //compare numbers - it can throw NotIncreasingException -> it has to be caught
        try
        {
            bool isIncreasingSequence = CheckIncreasingNumbers(numbers, start, end);
            if (isIncreasingSequence)
            {
                Console.Write(start + " < ");
                PrintSequence(numbers);
                Console.Write(end);
            }
        }
        catch (NotIncreasingException nie)
        {
            Console.WriteLine(nie.Message);
        }
    }

    static bool CheckIncreasingNumbers(int[] numbers, int start, int end)
    {
        bool isInRange = false;
        bool isIncreasing = false;
        if (start < numbers[0])
        {
            isInRange = true;
        }
        if (end > numbers[numbers.Length - 1])
        {
            isInRange = true;
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] < numbers[i])
            {
                isIncreasing = true;
            }
            else
            {
                isIncreasing = false;
                break;
            }
        }
        if (!(isIncreasing && isInRange))
        {
            throw new NotIncreasingException();
        }

        return isIncreasing && isInRange;
    }

    static void PrintSequence(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " < ");
        }
    }


    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException("The number is not in the specified range");
        }
        return number;
    }
}
