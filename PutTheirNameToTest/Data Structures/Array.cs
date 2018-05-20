using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Data_Structures
{
    class Array
    {
        static int[] reverseArray(int[] a)
        {
            /*
             * Write your code here.
             */
            int[] b = new int[a.Length];
            int j = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[j] = a[i];
                j++;
            }
            return b;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] res = reverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
