using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class CatsAndAMouse
    {
        static string catAndMouse(int x, int y, int z)
        {
            /*
             * Write your code here.
             */
            int cA = Math.Abs(z - x);
            int cB = Math.Abs(z - y);
            string res = "";
            if (cA < cB)
            {
                res = "Cat A";
            }
            else if (cA > cB)
            {
                res = "Cat B";
            }
            else if (cA == cB)
            {
                res = "Mouse C";
            }
            return res;
        }


        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                tw.WriteLine(result);
            }

            tw.Flush();
            tw.Close();
        }
    }
}
