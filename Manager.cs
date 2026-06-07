using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Manager : Employee
    {
        private string title;

        public static void Manager_UT()
        {
            //pass
        }
        
        public Manager(string title, string name, Date employmentDate) : base(name, employmentDate)
        {
            this.title = title;
        }

        public Manager(string title, string name, Date employmentDate, double salary) : base(name, employmentDate, salary)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public override double SalaryBonus()
        {
            return this.GetSalary() * 10;
        }

        public override string ToString()
        {
            string managerStr = $"{this.GetTitle()}\n{base.ToString()}";
            return managerStr;
        }
    }
}