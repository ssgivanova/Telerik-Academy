using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00RemoveArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = {1,4,3,3,6,3,2,3};
            int n = arr.Length;
            int[] arrOut = new int[n];
            int minRes = n;
            int j = 0;
            while (true)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (i == arrOut[j])
                            continue;
                    }
                    if (arr[i] > arr[i + 1])
                    {
                        if (minRes > n - i + j)
                        {
                            minRes = n - i + j;
                            arrOut[j] = i;
                            break;
                        }
                    }
                }
                j++;
            }
        }
    }
}
