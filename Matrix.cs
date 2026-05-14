using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Matrix
    {
        public static void Matrix_UT()
        {
            int[,] grades = { {80, 90, 100}, {50, 60, 70} };
            Console.WriteLine(Avrg(grades));
            Console.WriteLine(StudentAvg(grades, 0));
            Console.WriteLine(TestAvg(grades, 2));
            Console.WriteLine(MaxGrade(grades));
        }
        
        public static double Avrg(int[,] grades)
        {
            int sum = 0;
            double avg = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    sum += grades[row, col];
                }
            }
            avg = (double)sum / grades.Length;
            return avg;
        }

        public static double StudentAvg(int[,] mat, int student)
        {
            int sum = 0;
            double avg = 0;
            for (int col = 0; col < mat.GetLength(1); col++)
            {
                sum += mat[student, col];
            }
            avg = (double)sum / mat.GetLength(1);
            return avg;
        }

        public static double TestAvg(int[,] mat, int test)
        {
            int sum = 0;
            double avg = 0;
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                sum += mat[row, test];
            }
            avg = sum / mat.GetLength(0);
            return avg;
        }

        public static int MaxGrade(int[,] mat)
        {
            int max = 0;
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    if (mat[row, col] > max)
                    {
                        max = mat[row, col];
                    }
                }
            }
            return max;
        }
    }
}
