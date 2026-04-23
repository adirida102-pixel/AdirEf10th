using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    internal class StaticString
    {
        public static void StaticString_UT()
        {
            //Console.WriteLine(StaticString.StaticString1("Hello", 'e'));
            //Console.WriteLine(StaticString.StaticString2("ABC", "123"));
            //Console.WriteLine(StaticString.StaticString3("Adir", "Adir"));
            //Console.WriteLine(StaticString.StaticString4("Itay", "Adir"));
            //Console.WriteLine(StaticString.StaticString5("Hello"));
            //Console.WriteLine(StaticString.StaticString6A('a'));
            //Console.WriteLine(StaticString.StaticString6B("Adir"));
            //Console.WriteLine(StaticString.StaticString7("Haha", 'h'));
            //Console.WriteLine(StaticString.StaticString8("Hello World", 'W'));
            //Console.WriteLine(StaticString.StaticString9("Wo", "World"));
            //Console.WriteLine(StaticString.StaticString10("rld", "World"));
            //Console.WriteLine(StaticString.StaticString11("Hello World", 8));
            //Console.WriteLine(StaticString.StaticString12("Hello World", 3));
            //Console.WriteLine(StaticString.StaticString13("World", "Hello World"));
            //Console.WriteLine(StaticString.StaticString14("zaaaaafr", "zazazaz"));
            //Console.WriteLine(StaticString.StaticString15("aaa", "aaa"));
            //StringFuncs();
        }

        public static bool StaticString1(string str, char c)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool StaticString2(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                return true;
            }
            return false;
        }

        public static bool StaticString3(string s1, string s2)
        {
            bool ss = true;
            bool s1ls2l = false;
            for (int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    ss = false;
                }
            }
            if (s1.Length == s2.Length)
            {
                s1ls2l = true;
            }
            return ss && s1ls2l;
        }

        public static string StaticString4(string nameDst, string nameSrc)
        {
            string body;
            Console.Write("Enter the body of the letter: ");
            body = Console.ReadLine();
            Console.WriteLine();
            return $"Hello {nameDst}\n\n{body}\n\nBest Regards,\n{nameSrc}";
        }

        public static string StaticString5(string str)
        {
            string strR = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                strR += str[i];
            }
            return strR;
        }

        public static char StaticString6A(char c)
        {
            char cU;
            int x = 'a' - 'A';
            if (c >= 'a' && c <= 'z')
            {
                cU = (char)(c - x);
            }
            else
            {
                cU = c;
            }
            return cU;
        }

        public static string StaticString6B(string str)
        {
            string strU = "";
            for (int i = 0; i < str.Length; i++)
            {
                strU += StaticString.StaticString6A(str[i]);
            }
            return strU;
        }

        public static int StaticString7(string str, char c)
        {
            int x = 'a' - 'A';
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c || (str[i] == c + x || str[i] == c - x))
                {
                    count++;
                }
            }
            return count;
        }

        public static int StaticString8(string str, char c)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool StaticString9(string str1, string str2)
        {
            int count = 0;
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] == str1[i])
                    {
                        count++;
                    }
                }
                if (count == str2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        count++;
                    }
                }
                if (count == str1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool StaticString10(string str1, string str2)
        {
            int count = 0;
            if (str1.Length > str2.Length)
            {
                for (int i = str1.Length - str2.Length; i < str1.Length; i++)
                {
                    if (str2[i - str1.Length + str2.Length] == str1[i])
                    {
                        count++;
                    }
                }
                if (count == str2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                for (int i = str2.Length - str1.Length; i < str2.Length; i++)
                {
                    if (str1[i - str2.Length + str1.Length] == str2[i])
                    {
                        count++;
                    }
                }
                if (count == str1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static string StaticString11(string str, int k)
        {
            string strk = "";
            for (int i = 0; i <= k; i++)
            {
                if (k <= str.Length)
                {
                    strk += str[i];
                }
            }
            return strk;
        }

        public static string StaticString12(string str, int k)
        {
            string strk = "";
            for (int i = k; i < str.Length; i++)
            {
                if (k <= str.Length)
                {
                    strk += str[i];
                }
            }
            return strk;
        }

        public static bool StaticString13(string str1, string str2)
        {
            int indexInside = 0;
            int count = 0;
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[indexInside])
                    {
                        indexInside = 0;
                        for (int j = 0; j < str2.Length; j++)
                        {
                            count++;
                        }
                        if (count == str2.Length)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] == str1[indexInside])
                    {
                        indexInside = 0;
                        for (int j = 0; j < str1.Length; j++)
                        {
                            count++;
                        }
                        if (count == str1.Length)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static string StaticString14(string str1, string str2)
        {
            string str1U = StaticString.StaticString6B(str1);
            string str2U = StaticString.StaticString6B(str2);
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1U[i] > str2U[i])
                    {
                        return str1;
                    }
                    else if (str1U[i] > str2U[i])
                    {
                        return str2;
                    }
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1U[i] > str2U[i])
                    {
                        return str1;
                    }
                    else if (str1U[i] < str2U[i])
                    {
                        return str2;
                    }
                }
            }
            return str2;
        }

        public static int StaticString15(string str1, string str2)
        {
            if (StaticString.StaticString3(str1, str2))
            {
                return 0;
            }
            else if (StaticString.StaticString14(str1, str2) == str1)
            {
                return 1;
            }
            else
            {
                return -1;
            }    
        }
        public static void StringFuncs()
        {
            string str = "Hello Josh!";
            string s2 = str.ToUpper();
            Console.WriteLine(s2);
            Console.WriteLine(str.CompareTo(s2));
        }
    }
}