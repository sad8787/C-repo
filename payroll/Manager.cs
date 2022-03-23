using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    public class Manager : Employee
    {
        List<Employee> subordinates;
        public Manager(string name, DateTime dateOfAdmission, double baseSalary)
            :base(name, dateOfAdmission,  baseSalary)
        { 
        
        }
        public Manager(string name, DateTime dateOfAdmission, double baseSalary, Employee boss)
            : base(name, dateOfAdmission, baseSalary,boss)
        {

        }

        public List<Employee> Subordinates { get => subordinates; set => subordinates = value; }

        public void AddSubordinate(Employee employee) {
            Subordinates.Add(employee);
        }
        public override double CalculatePay(DateTime localDate)
        {
            
            int years = localDate.Year - dateOfAdmission.Year;
            double bonuses = 0;
            if (subordinates != null)
            {
                foreach (var item in subordinates)
                {
                    bonuses += item.CalculatePay(localDate);
                }
            }

            if (years <= 8)
            {
                return ((baseSalary / 100) * (years * 5)) + baseSalary+((bonuses/100)*0.5);
            }
            else
            {
                return ((baseSalary / 100) * (40)) + baseSalary + ((bonuses / 100) * 0.5);
            }

        }

      


    }
}
