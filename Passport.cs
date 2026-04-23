using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdirEf10th
{
    public class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;

        public static void PassportUT()
        {
            //Passport pass1 = new Passport("Adir", 102, new Date(18, 5, 2030));
            //Passport pass2 = new Passport("Itay", 111, new Date(31, 1, 2020));
            //Console.WriteLine(pass1);
            //Console.WriteLine(pass2);
            //Console.WriteLine(pass1.IsValid(new Date()));
            //Console.WriteLine(pass2.IsValid(new Date()));
            //Console.WriteLine(pass1.IsValid(new Date(1, 1, 2050)));
            //Passport[] passports = {pass1, pass2};
            //Passport[] exp = AllExpired(passports);
            //for (int i = 0; i < exp.Length; i++)
            //{
            //    Console.WriteLine(exp[i]);
            //}
        }

        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }

        public Passport(Passport passport)
        {
            this.name = passport.name;
            this.number = passport.number;
            this.expiryDate = passport.expiryDate;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public Date GetExpiryDate()
        {
            return this.expiryDate;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetExpiryDate(Date expiryDate)
        {
            this.expiryDate.SetDay(expiryDate.GetDay());
            this.expiryDate.SetMonth(expiryDate.GetMonth());
            this.expiryDate.SetYear(expiryDate.GetYear());
        }

        public bool IsValid(Date dateChecked)
        {
            bool b;
            int num = this.GetExpiryDate().CompareTo(dateChecked);
            b = (num > 0) ? true : false;
            return b;
        }

        public override string ToString()
        {
            string str = "";
            str += $"Name: {this.GetName()}\n";
            str += $"Pass. num: {this.GetNumber()}\n";
            str += $"Exp date: {this.expiryDate.ToString()}";
            return str;
        }

        public static Passport[] AllExpired(Passport[] passports)
        {
            Passport[] expired;
            int expCount = 0, expFollow = 0;
            for (int i = 0; i < passports.Length; i++)
            {
                if (!(passports[i].IsValid(new Date())))
                {
                    expCount++;
                }
            }
            expired = new Passport[expCount];
            for (int i = 0; i < passports.Length; i++)
            {
                if (!(passports[i].IsValid(new Date())))
                {
                    expired[expFollow] = passports[i];
                    expFollow++;
                }
            }
            return expired;
        }
    }
}
