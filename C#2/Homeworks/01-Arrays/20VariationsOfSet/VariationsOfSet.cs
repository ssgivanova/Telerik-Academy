using System;
/*
Write a program that reads two numbers  N  and  K  and generates all the variations of  K  elements 
from the set [ 1..N ].

 n = 3
 k = 2
 {1, 1}  
 {1, 2}  
 {1, 3}  
 {2, 1}  
 {2, 2}  
 {2, 3}  
 {3, 1}  
 {3, 2}  
 {3, 3} 
 * */

class VariationsOfSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nbrVariations = (int)Math.Pow(n,k); //( 3 permutations of 3 elements) = n^3 -> n^n
        
        Console.WriteLine(nbrVariations);

        for (int i = 1; i <= nbrVariations; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                
            }
            Console.WriteLine();
            
        }
    }
}
