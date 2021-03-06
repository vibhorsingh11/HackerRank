﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Data_Structures
{
    class _2D_Array___DS
    {
        static int array2D(int[][] arr)
        {

            int max_sum = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = (arr[i][j] + arr[i][j + 1] +
                               arr[i][j + 2]) + (arr[i + 1][j + 1]) +
                              (arr[i + 2][j] + arr[i + 2][j + 1] +
                               arr[i + 2][j + 2]);

                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;

        }
        public static void Main(string[] agrs)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = array2D(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
