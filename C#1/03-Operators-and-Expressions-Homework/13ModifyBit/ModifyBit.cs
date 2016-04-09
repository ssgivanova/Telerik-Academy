using System;

//We are given an integer number N(read from the console), a bit value v(read from the console as well) 
//(v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of 
//C# code) that modifies N to hold the value v at the position P from the binary representation of N 
//while preserving all other bits in N. Print the resulting number on the console.

//input :
//First line - the integer number N.
//Second line - the position P.
//Third line - the bit value v.

//output : 
//single line containing the value of the number N with the modified bit



class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        //get the current bit value
        ulong mask = 0;
        ulong invertedMask = 0;
        mask = (ulong)(1 << p);
        invertedMask = ~((ulong)1 << p);//    (ulong)(~(ulong)(1 << p));
        ulong nAndMask = n & mask;
        ulong currentBit = nAndMask >> p;

        ulong result = 0;

        //the bit has to be changed to 0
        if (v == 0)
        {
            if (currentBit == 0)
            {
                //no change need
                result = n;
            }
            else if (currentBit == 1)
            {
                //set the current bit to 0
                result = (ulong)(n & invertedMask);
            }
        }
        else
        {
            if (currentBit == 0)
            {
                //set the bit to 0
                result = (ulong)(n | mask);
            }
            if (currentBit == 1)
            {
                //no change needed
                result = n;
            }
        }
        Console.WriteLine(result);
    }
}