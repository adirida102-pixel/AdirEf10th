using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class CssGrades
    {
        string name;
        int magen371;
        int bagrut371;
        int magen271;
        int bagrut271;
        int proj;
        //public --> private

        public CssGrades(string n, int m3, int b3, int m2, int b2, int p)
        {
            name = n;
            magen371 = m3;
            bagrut371 = b3;
            magen271 = m2;
            bagrut271 = b2;
            proj = p;
        } //CONVENTION #1

        public void SetBagrut271(int b2)
        {
            if (b2 >= 0 && b2 <= 100)
            {
                bagrut271 = b2;
            }
        } //COVENTION #2

        public int GetBagrut271()
        {
            return bagrut271;
        } //CONVENTION #3

        public int Calc371()
        {
            return (int)(magen371 * 0.3 + bagrut371 * 0.7 + 0.5);
        }
        public int Calc271()
        {
            return (int)(magen271 * 0.4 + bagrut271 * 0.6 + 0.5);
        }
        public bool Has5()
        {
            return bagrut271 >= 55;
        }
        public int Calc3()
        {
            return (int)(Calc371() * 0.6 + proj * 0.4 + 0.5);
        }
        public int Calc5()
        {
            return (int)(Calc271() * 0.4 + Calc3() * 0.6 + 0.5);
        }
        public string FinalString()
        {
            string s = "";
            int final;
            if (Has5())
            {
                s = "You got 5 units in CS!\n";
                final = Calc5();
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = Calc3();
            }
            s += "Your final grade is: " + final;
            return s;
        }

        public override string ToString()
        {
            string s = "";
            int final;
            if (Has5())
            {
                s = "You got 5 units in CS!\n";
                final = Calc5();
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = Calc3();
            }
            s += "Your final grade is: " + final;
            return s;
        }
    }
}