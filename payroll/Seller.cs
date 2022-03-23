using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    public class Seller:Employee
    {
        List<Employee> subordinates;
        public Seller(string name, DateTime dateOfAdmission, double baseSalary)
            : base(name, dateOfAdmission, baseSalary)
        {

        }
        public Seller(string name, DateTime dateOfAdmission, double baseSalary, Employee boss)
            : base(name, dateOfAdmission, baseSalary, boss)
        {

        }
      

        public List<Employee> Subordinates   // property
        {
            get { return subordinates; }   // get method
            set { subordinates = value; }  // set method
        }

        public void AddSubordinate(Employee employee)
        {
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
                    if (item is Manager)
                    {
                        if (((Manager)item).Subordinates != null)
                        {
                            foreach (var sub in ((Manager)item).Subordinates)
                            {
                                bonuses += sub.CalculatePay(localDate);
                            }
                        }
                        
                    }
                    else if (item is Seller)
                    {
                        if (((Seller)item).Subordinates != null) 
                        {
                            foreach (var sub in ((Seller)item).Subordinates)
                            {
                                bonuses += sub.CalculatePay(localDate);
                            }
                        }
                        
                    }
                    else
                    {
                        bonuses += item.CalculatePay(localDate);
                    }
                }

            }            
           

            if (years <=35)
            {
                return ((baseSalary / 100) * (years )) + baseSalary + ((bonuses / 100) * 0.3);
            }
            else
            {
                return ((baseSalary / 100) * (35)) + baseSalary + ((bonuses / 100) * 0.3);
            }

        }

      

    }
}
