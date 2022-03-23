using System;

namespace payroll
{
    public class Employee
    {
        protected internal string name;
        protected internal DateTime dateOfAdmission;
        protected internal double baseSalary;
        protected internal Employee boss;
        public Employee() { }
        public Employee(string name, DateTime dateOfAdmission, double baseSalary) {
            this.name = name;
            this.dateOfAdmission = dateOfAdmission;
            this.baseSalary = baseSalary;
            this.boss = null;
        }
        public Employee(string name, DateTime dateOfAdmission, double baseSalary, Employee boss)
        {
            this.name = name;
            this.dateOfAdmission = dateOfAdmission;
            this.baseSalary = baseSalary;
            this.boss = boss;
        }
        
        #region property
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public DateTime DateOfAdmission   // property
        {
            get { return dateOfAdmission; }   // get method
            set { dateOfAdmission = value; }  // set method
        }
        public double BaseSalary   // property
        {
            get { return baseSalary; }   // get method
            set { baseSalary = value; }  // set method
        }
        public Employee Boss   // property
        {
            get { return boss; }   // get method
            set { boss = value; }  // set method
        }
        #endregion

        //Pay
        public virtual double CalculatePay(DateTime localDate)
        {
            
            int years = localDate.Year - dateOfAdmission.Year;
            if (years < 11)
            {
                return ((baseSalary / 100) * (years * 3)) + baseSalary;
            }
            else
            {
                return ((baseSalary / 100) * (30)) + baseSalary;
            }
            
        }

      


    }
}
