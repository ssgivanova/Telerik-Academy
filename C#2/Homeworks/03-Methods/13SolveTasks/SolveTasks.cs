using System;
/*
Write a program that can solve these tasks:
•Reverses the digits of a number
•Calculates the average of a sequence of integers
•Solves a linear equation  a * x + b = 0 

Create appropriate methods.
•Provide a simple text-based menu for the user to choose which task to solve.
•Validate the input data: ◦The decimal number should be non-negative
◦The sequence should not be empty
◦ a  should not be equal to  0 


 */
class SolveTasks
{
   static void Main()
   {
       //menu
       Console.WriteLine("\nChoose a task to solve :");
       Console.WriteLine(new string('-',52));
       Console.WriteLine("1. Reverses the digits of a number");
       Console.WriteLine("2. Calculates the average of a sequence of integers");
       Console.WriteLine("3. Solves a linear equation  a * x + b = 0");
       Console.WriteLine(new string('-', 52));

       int choice = int.Parse(Console.ReadLine());
       switch(choice)
       {
           case 1 : 
               Console.WriteLine("Enter a number :");
               int nbr = int.Parse(Console.ReadLine());
               while (nbr < 0)
               {
                   Console.WriteLine("Invalid number - must be > 0");
                   Console.WriteLine("Enter new number :");
                   nbr = int.Parse(Console.ReadLine());
               }
               string reversed = ReverseNumber(nbr);
               Console.WriteLine("The reversed number is {0}",reversed);
               break;
           case 2 :
               Console.WriteLine("Enter a number n :");
               int n = int.Parse(Console.ReadLine());
               while (n == 0)
               {
                   Console.WriteLine("Invalid number - the sequence should not be empty");
                   Console.WriteLine("Enter new number :");
                   n = int.Parse(Console.ReadLine());
               }
               int[] integers = new int[n];
               Console.WriteLine("Enter sequence numbers :");
               for (int i = 0; i < integers.Length; i++)
               {
                   integers[i] = int.Parse(Console.ReadLine());
               }
               double avg = CalculateAverageOfSequenceIntegers(integers);
               Console.WriteLine("The average of the sequence number is {0}",avg);
               break;
           case 3 :
               Console.WriteLine("Enter a coefficients a and b :");
               Console.Write("Enter a =");
               double a = double.Parse(Console.ReadLine());
               while (a == 0)
               {
                   Console.WriteLine("Invalid number - must be different from 0");
                   Console.WriteLine("Enter new number :");
                   a = double.Parse(Console.ReadLine());
               }
               Console.Write("Enter b =");
               double b = double.Parse(Console.ReadLine());
               double result = SolveLinearEquation(a,b);
               Console.WriteLine("The result is x = {0}",result);
               break;
           default: Console.WriteLine("invalid choice"); break;
       }
   }

   static string ReverseNumber(int n)
   {
       char[] digits = n.ToString().ToCharArray();
       string result = "";
       //Array.Reverse(digits);
       //string result = new string(digits);

       for (int i = digits.Length - 1; i >= 0; i--)
       {
           result += digits[i];
       }
       return result;
   }

    static double CalculateAverageOfSequenceIntegers(int[]arr)
    {
        //The sequence should not be empty
        double avg = 0.0;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        avg = (double)sum / arr.Length;
        return avg;
    }

    static double SolveLinearEquation(double a,double b){
        //a  should not be equal to  0 
        //a * x + b = 0 
        double x =(-b)/a;
        return x;
    }

}
