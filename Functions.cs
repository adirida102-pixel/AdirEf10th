using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    internal class Functions
    {
        public static bool StaticFuncs1A_f(int month, int year)
        {
            return (month >= 1 && month <= 6 && year == 2009);
        }

        public static double StaticFuncs2A_f(int age, double maxSpeed, int years)
        {
            if (age < 24 && years < 2)
            {
                return maxSpeed - 10;
            }
            else
            {
                return maxSpeed;
            }
        }

        public static double StaticFuncs3A_f(int years, double moneySpent)
        {
            if (years > 3 && moneySpent > 1200)
            {
                if (years < 8)
                {
                    return years * 50;
                }
                else
                {
                    return years * 100;
                }
            }
            else
            {
                return 0;
            }
        }

        public static bool StaticFuncs4A_f(int age)
        {
            if (age >= 15 && age <= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int StaticFuncs5A_f(int grade1, int grade2, int grade3)
        {
            int count = 0;
            if (grade1 > 90)
            {
                count++;
            }
            if (grade2 > 90)
            {
                count++;
            }
            if (grade3 > 90)
            {
                count++;
            }
            return count;
        }

        public static bool StaticFuncs6A_f(int num)
        {
            double price, sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter price: ");
                price = double.Parse(Console.ReadLine());
                sum += price;
            }
            if (sum > 150)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static char StaticFuncs8A_f(string sex1, string sex2)
        {
            if (sex1 == "male" && sex2 == "male")
            {
                return 'm';
            }
            else if (sex1 == "female" && sex2 == "female")
            {
                return 'f';
            }
            else
            {
                return 'v';
            }
        }

        public static int StaticFuncs10A_f(int first, int second)
        {
            return (second / 100 * 60 + second % 100) - (first / 100 * 60 + first % 100);
        }

        public static double StaticFuncs12A_f(double price1, double price2)
        {
            if (price1 >  price2)
            {
                return price1 + price2 / 2;
            }
            else
            {
                return price2 + price1 / 2;
            }
        }

        public static double StaticFuncs12AB_f(double price1, double price2, double price3)
        {
            if (Math.Min(price1, Math.Min(price2, price3)) == price1)
            {
                return price2 + price3;
            }
            if (Math.Min(price1, Math.Min(price2, price3)) == price2)
            {
                return price1 + price3;
            }
            else
            {
                return price1 + price2;
            }
        }

        public static double StaticFuncs12B_f(int num)
        {
            double price1, price2, price3;
            Console.Write("Enter the first book's price: ");
            price1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second book's price: ");
            price2 = int.Parse(Console.ReadLine());
            if (num == 2)
            {
                return Functions.StaticFuncs12A_f(price1, price2);
            }
            else
            {
                Console.Write("Enter the third book's price: ");
                price3 = int.Parse(Console.ReadLine());
                return Functions.StaticFuncs12AB_f(price1, price2, price3);
            }
        }

        public static int StaticFuncs14A_f(int num, int digit)
        {
            return num * 10 + digit;
        }

        public static int StaticFuncs14B_f(int num)
        {
            int digit = num;
            while (digit != 0 && digit != 9)
            {
                Console.WriteLine("Enter the next digit:");
                digit = int.Parse(Console.ReadLine());
                num = Functions.StaticFuncs14A_f(num, digit);
            }
            return num;
        }
    }
}
