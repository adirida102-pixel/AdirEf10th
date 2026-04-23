using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yod;

namespace AdirEf10th
{
    internal class Cypher
    {
        public static void CypherUT()
        {
            //Console.WriteLine(CharEncryptCaesar('a', 3));
            //Console.WriteLine(StringEncryptCaesar("hello i am a person", 8));
            //Console.WriteLine(StringDecryptCaesar("pmttw q iu i xmzawv", 8));
            //Console.WriteLine(StringEncryptMix("Cya l8r"));
            //Console.WriteLine(BestKey("pmttw q iu i xmzawv"));
        }
        
        public static char CharEncryptCaesar(char ch, int num)
        {
            int numa = 'a';
            int numz = 'z';
            int numA = 'A';
            int numZ = 'Z';
            int letDif = 'Z' - 'A' + 1;
            char newCh = ' ';
            num %= letDif;
            if (ch >= numa && ch <= numz || ch >= numA && ch <= numZ)
            {
                newCh = (char)(ch + num);
                if (!(newCh >= numa && newCh <= numz || newCh >= numA && newCh <= numZ) || ((ch >= numA && ch <= numZ) && (newCh >= numa && newCh <= numz)) || ((ch >= numa && ch <= numz) && (newCh >= numA && newCh <= numZ)))
                {
                    if (ch >= numA && ch <= numZ)
                    {
                        if (newCh < numA)
                        {
                            newCh += (char)letDif;
                        }
                        else
                        {
                            newCh -= (char)letDif;
                        }
                    }
                    else if (ch >= numa && ch <= numz)
                    {
                        if (newCh < numa)
                        {
                            newCh += (char)letDif;
                        }
                        else
                        {
                            newCh -= (char)letDif;
                        }
                    }
                }
            }
            return newCh;
        }

        public static string StringEncryptCaesar(string str, int num)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += CharEncryptCaesar(str[i], num);
            }
            return newStr;
        }

        public static string StringDecryptCaesar(string str, int num)
        {
            num *= -1;
            return StringEncryptCaesar(str, num);
        }

        public static string StringEncryptMix(string str)
        {
            string newStr = "";
            bool sw = false;
            for (int i = 1; i < str.Length; i += 0)
            {
                newStr += str[i];
                if (sw)
                {
                    i += 3;
                    sw = false;
                }
                else
                {
                    i--;
                    sw = true;
                }
            }
            if (str.Length % 2 == 1)
            {
                newStr += str[str.Length - 1];
            }
            return newStr;
        }

        public static double BestKeyPer(string str)
        {
            string newStr = "";
            double perSum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    perSum += EnglishWordChecker.GetEnglishWordPercentage(newStr);
                    newStr = "";
                }
                else
                {
                    newStr += str[i];
                }
            }
            perSum += EnglishWordChecker.GetEnglishWordPercentage(newStr);
            return perSum;
        }

        public static int BestKey(string encrypted)
        {
            double bestPer = 0;
            int bestKey = 0;
            string decrypted;
            for (int i = 0; i < 26; i++)
            {
                decrypted = StringDecryptCaesar(encrypted, i);
                if (BestKeyPer(decrypted) > bestPer)
                {
                    bestPer = BestKeyPer(decrypted);
                    bestKey = i;
                }
            }
            return bestKey;
        }
    }
}
