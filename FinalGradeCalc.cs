using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    internal class FinalGradeCalc
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Calc371(90, 95));
            //Console.WriteLine(Calc371(90, 94));
            //Console.WriteLine(Calc3(67, 80));
            //Console.WriteLine(Calc3(68, 80));
            //Console.WriteLine(Calc271(80, 67));
            //Console.WriteLine(Calc271(80, 68));
            //Console.WriteLine(Calc5(80, 67));
            //Console.WriteLine(Calc5(80, 68));
            string str = FinalString(80, 90, 80, 87, 100);
            Console.WriteLine(str);
        }
        
        private static int Calc371(int magen371, int bagrut371)
        {
            return (int)(magen371 * 0.3 + bagrut371 * 0.7 + 0.5);
        }

        private static int Calc3(int final371, int proj)
        {
            return (int)(final371 * 0.6 + proj * 0.4 + 0.5);
        }

        private static int Calc271(int magen271, int bagrut271)
        {
            return (int)(magen271 * 0.4 + bagrut271 * 0.6 + 0.5);
        }

        private static bool Has5(int bagrut271)
        {
            return bagrut271 >= 55;
        }

        private static int Calc5(int final271, int final3)
        {
            return (int)(final271 * 0.4 + final3 * 0.6 + 0.5);
        }

        public static string FinalString(int magen371, int bagrut371, int magen271, int bagrut271, int proj)
        {
            string s = "";
            int f371 = Calc371(magen371, bagrut371);
            int f3 = Calc3(f371, proj);
            int final;
            if (Has5(bagrut271))
            {
                s = "You got 5 units in CS!\n";
                int f271 = Calc271(magen271, bagrut271);
                final = Calc5(f271, f3);
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = f3;
            }
            s += "Your final grade is: " + final;
            return s;
        }
    }
}