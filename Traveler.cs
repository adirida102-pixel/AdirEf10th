using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Traveler
    {
        private Passport passport;
        private bool hasPaid;

        public static void TravelerUT()
        {
            //Traveler t1 = new Traveler(new Passport("Adir", 102, new Date(18, 5, 2030)), false);
            //Traveler t2 = new Traveler(new Passport("Itay", 69, new Date(31, 1, 2025)), true);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t1.CheckTravel(new Date()));
            //Console.WriteLine(t2.CheckTravel(new Date()));
            //t1.Pay();
            //Console.WriteLine(t1.CheckTravel(new Date()));
            //Console.WriteLine(t2.CheckTravel(new Date()));
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Traveler[] travelers = { t1, t2 };
            //Console.WriteLine(NumAllowed(travelers));
            //t1.Pay();
            //Console.WriteLine(NumAllowed(travelers));
        }

        public Traveler(Passport passport, bool hasPaid)
        {
            this.passport = passport;
            this.hasPaid = hasPaid;
        }

        public Passport GetPassport()
        {
            return this.passport;
        }

        public bool HasPaid()
        {
            return this.hasPaid;
        }

        public void SetPassport(Passport passport)
        {
            this.passport = passport;
        }

        public void SetHasPaid(bool hasPaid)
        {
            this.hasPaid = hasPaid;
        }

        public void Pay()
        {
            this.SetHasPaid(true);
        }

        public bool CheckTravel(Date travelDate)
        {
            bool b = this.GetPassport().IsValid(travelDate) && this.HasPaid();
            return b;
        }

        public override string ToString()
        {
            string str = "";
            str += this.GetPassport().ToString() + "\n";
            str += $"Has paid: {this.HasPaid()}";
            return str;
        }

        public static int NumAllowed(Traveler[] travelers)
        {
            int canGoCount = 0;
            for (int i = 0; i < travelers.Length; i++)
            {
                if (travelers[i].CheckTravel(new Date()))
                {
                    canGoCount++;
                }
            }
            return canGoCount;
        }
    }
}
