using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class CheckingAccount
    {
        const double DEFAULT_OVERDRAFT = 1000;

        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string accountID;
        private double balance;
        private double overdraft;

        public static void CheckingAccount_UT()
        {
            //CheckingAccount a1 = new CheckingAccount(1, 1, 1, "1");
            //CheckingAccount a2 = new CheckingAccount(2, 2, 2, "2", 100);
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Deposit(100));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(300));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(500));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(200));
            //Console.WriteLine(a2);
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string accountID)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.accountID = accountID;
            this.balance = 0;
            this.overdraft = CheckingAccount.DEFAULT_OVERDRAFT;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string accountID, double overdraft)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.accountID = accountID;
            this.balance = 0;
            this.overdraft = overdraft;
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

        public double GetOverdraft()
        {
            return this.overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft >= 0)
            {
                this.overdraft = overdraft;
            }
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

        public bool Withdrawal(int num)
        {
            bool success = false;
            if (num > 0 && this.balance - num > -1 * this.overdraft)
            {
                this.balance -= num;
                success = true;
            }
            return success;
        }

        public override string ToString()
        {
            string checkingString = $"Bank number: {this.GetBankNum()}\nBranch number: {this.GetBranchNum()}\nAccount number: {this.GetAccountNum()}\nAccount ID: {this.GetAccountID()}\nBalance: {this.GetBalance()}\nOverdraft: {this.GetOverdraft()}";
            return checkingString;
        }
    }
}
