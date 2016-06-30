namespace BitArray
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Collections;

    class BitArray64 :IEnumerable<int>
    {
        //Define a class  BitArray64  to hold  64  bit values inside an  ulong  value.
        
        private const int Length = 64;
        private int[] bits = new int[Length];

        public BitArray64(ulong number)
        {
            string binary = ConvertDecimalToBinary(number);
            this.bits = BitsIntoArray(binary);
        }

        //Implement  IEnumerable<int>  and  Equals(…) ,  GetHashCode() ,  [] ,  ==  and  != .

        public override bool Equals(object other)
        {
            var otherArray = other as BitArray64;

            for (int i = 0; i < Length; i++)
            {
                if (!otherArray[i].Equals(this[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid index.Index must be [0,63]");
                }

                return this.bits[index];
            }
            set
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid inde.Index must be [0,63]");
                }
                this.bits[index] = value;
            }
        }

        public static bool operator == (BitArray64 arr1, BitArray64 arr2)
        {
            return arr1.Equals(arr2);
        }

        public static bool operator != (BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1==arr2);
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            for (int i = 0; i < Length; i++)
            {
                hashCode += (bits[i].GetHashCode()*397) ^ i;
            }

            return hashCode;
        }

        public override string ToString()
        {
            return String.Join("", bits);
        }

        //methods for IEnumerable
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int bit in bits)
            {
                yield return bit;
            }
            //for (int i = 0; i < Length; i++)
            //{
            //    yield return this[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //helper methods
        private string ConvertDecimalToBinary(ulong number)
        {
            string binaryTemp = "";
            ulong baseBin = 2;

            while (number > 0)
            {
                ulong remainder = number % baseBin;
                number /= baseBin;
                binaryTemp  += remainder;
            }

            //reverse
            string binary = Reverse(binaryTemp).PadLeft(64, '0');
            return binary.ToString();
        }

        private int[] BitsIntoArray(string binary)
        {
            int[] bitArray = new int[Length];
            for (int i = 0; i < binary.Length; i++)
            {
                bitArray[i] = int.Parse(binary[i].ToString());
            }
            return bitArray;
        }

        private string Reverse(string input)
        {
            string result = "";
            for (int i = input.Length-1; i > 0; i--)
            {
                result += input[i];
            }
            return result;
        }

        
    }
}
