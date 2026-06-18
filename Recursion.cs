using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Recursion
    {
        public static void Recursion_UT()
        {
            //Console.WriteLine(DigitNum(1234));
            //Console.WriteLine(DigitNum(1234567));
            //Console.WriteLine(DigitNumRecursive(12345));
            //Console.WriteLine(DigitNumRecursive(12));
        }
        
        public static int DigitNum(int num)
        {
            int count = 0;
            int x = num;
            while (x > 0)
            {
                count++;
                x /= 10;
            }
            return count;
        }

        public static int DigitNumRecursive(int num)
        {
            int count = 0;
            if (num == 0)
            {
                count = 0;
            }
            else
            {
                count = DigitNumRecursive(num / 10) + 1;
            }
            return count;
        }
    }
}
