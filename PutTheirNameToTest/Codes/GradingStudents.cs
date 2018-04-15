using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Codes
{
    class GradingStudents
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = { 37, 38 };



            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();

        }

        static int[] gradingStudents(int[] grades)
        {
            /*
             * Write your code here.
             */
            int[] multiple = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            for (int i = 0; i <= grades.Length - 1; i++)
            {
                for (int j = 0; j <= multiple.Length - 1; j++)
                {
                    if (grades[i] < 38)
                    {
                        break;
                    }
                    else
                    {
                        if (grades[i] < multiple[j])
                        {
                            int diff = multiple[j] - grades[i];
                            if (diff < 3)
                            {
                                grades[i] = multiple[j];
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return grades;
        }

    }
}
