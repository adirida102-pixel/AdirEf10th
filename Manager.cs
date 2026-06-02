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

        public Manager(string title, string name, Date employmentDate) : base(name, employmentDate) //check if possible without ':', inside the function
        {
            this.title = title;
        }

        public Manager(string title, string name, Date employmentDate, double salary) : base(name, employmentDate, salary) //check if possible without ':', inside the function
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }

        //bonus function: virtual? -> override???

        //tostring function: base?

        //check later
    }
}
