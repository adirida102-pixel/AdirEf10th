using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class SavingAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string accountID;
        private double balance;
        private Date endDate;

        public static void SavingAccount_UT()
        {
            //SavingAccount a1 = new SavingAccount(1, 1, 1, "1", new Date(1, 1, 2030));
            //SavingAccount a2 = new SavingAccount(2, 2, 2, "2", new Date(2, 2, 2025));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Deposit(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(-200, new Date(1, 1, 1)));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(400, new Date(11, 11, 11)));
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(-1));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(200));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(222, new Date(2, 2, 2)));
            //Console.WriteLine(a2);
            //a2.SetEndDate(new Date(2, 2, 2222));
            //Console.WriteLine(a2);
        }

        public SavingAccount(int bankNum, int branchNum, int accountNum, string accountID, Date endDate)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.accountID = accountID;
            this.balance = 0;
            this.endDate = endDate;
        }

        public int GetBankNum()
        {
            return this.bankNum;
        }

        public int GetBranchNum()
        {
            return this.branchNum;
        }

        public int GetAccountNum()
        {
            return this.accountNum;
        }

        public string GetAccountID()
        {
            return this.accountID;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public Date GetEndDate()
        {
            return this.endDate;
        }

        public void SetEndDate(Date endDate)
        {
            this.endDate = endDate;
        }

        public bool Deposit(int num)
        {
            bool success = false;
            if (num > 0)
            {
                this.balance += num;
                success = true;
            }
            return success;
        }

        public bool Withdrawal(int num, Date date)
        {
            bool success = false;
            if (num > 0 && this.GetEndDate().CompareTo(date) != -1)
            {
                this.balance -= num;
                success = true;
            }
            return success;
        }

        public override string ToString()
        {
            string savingString = $"Bank number: {this.GetBankNum()}\nBranch number: {this.GetBranchNum()}\nAccount number: {this.GetAccountNum()}\nAccount ID: {this.GetAccountID()}\nBalance: {this.GetBalance()}\nEnd date: {this.GetEndDate().ToString()}";
            return savingString;
        }
    }
}
