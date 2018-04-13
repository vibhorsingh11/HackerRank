using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Codes
{
    class BigSorting
    {
        static String[] bigSorting(string[] arr)
        {
            // Complete this function
            int c = arr.Length;
            long[] iarr = new long[c];
            for (int j = 0; j < arr.Length - 1; j++)
            {
                iarr[j] = long.Parse(arr[j]);
            }
            for (int i = 0; i < iarr.Length; i++)
            {
                if (iarr[i] > iarr[i + 1])
                {
                    long temp = iarr[i + 1];
                    iarr[i + 1] = iarr[i];
                    iarr[i] = temp;
                }
            }
            string[] strarr = new string[iarr.Length];
            for (int k = 0; k < iarr.Length; k++)
            {
                strarr[k] = Convert.ToString(iarr[k]);
            }

            return strarr;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            string[] result = bigSorting(arr);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
