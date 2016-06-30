namespace BitArray
{

//    Problem 5. 64 Bit array
//• Define a class  BitArray64  to hold  64  bit values inside an  ulong  value.
//• Implement  IEnumerable<int>  and  Equals(…) ,  GetHashCode() ,  [] ,  ==  and  != .


    using System;

    class Startup
    {
        static void Main()
        {
            BitArray64 bitArr1 = new BitArray64(354556);
            BitArray64 bitArr2 = new BitArray64(507895);
            BitArray64 bitArr3 = new BitArray64(354556);

            Console.WriteLine(bitArr1);
            Console.WriteLine(bitArr2);
            Console.WriteLine(bitArr1 == bitArr2);
            Console.WriteLine(bitArr1 != bitArr2);

            Console.WriteLine();
            Console.WriteLine(bitArr1 == bitArr3);
            Console.WriteLine(bitArr1.Equals(bitArr3));

            int bit60 = bitArr3[61];
            Console.WriteLine(bit60);

            foreach (int bit in bitArr3)
            {
                Console.Write(bit +" ");
            }

        }
    }
}
