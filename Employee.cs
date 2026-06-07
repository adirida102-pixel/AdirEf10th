using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Employee
    {
        private const double DEFAULT_SALARY = 2000;
        private string name;
        private Date employmentDate;
        private double salary;

        public static void Employee_UT()
        {
            //pass
        }
        
        public Employee(string name, Date employmentDate)
        {
            this.name = name;
            this.employmentDate = employmentDate;
            this.salary = Employee.DEFAULT_SALARY;
        }

        public Employee(string name, Date employmentDate, double salary)
        {
            this.name = name;
            this.employmentDate = employmentDate;
            this.salary = salary;
        }

        public string GetName()
        {
            return this.name;
        }

        public Date GetEmploymentDate()
        {
            return new Date(this.employmentDate);
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(double salary)
        {
            double finalSalary = 0;
            if (salary > 0)
            {
                finalSalary = salary;
            }
            else
            {
                finalSalary = Employee.DEFAULT_SALARY;
            }
            this.salary = finalSalary;
        }

        public virtual double SalaryBonus()
        {
            return this.GetSalary() * 1.7;
        }

        public override string ToString()
        {
            string employeeString = "";
            employeeString += $"Name: {this.GetName()}\n";
            employeeString += $"Employment date: {this.GetEmploymentDate()}\n";
            employeeString += $"Salary: {this.GetSalary()}";
            return employeeString;
        }
    }
}
