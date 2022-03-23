using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    public class Company
    {
        protected List<Employee> employees;
        public List<Employee> Employees   // property
        {
            get { return employees; }   // get method
            set { employees = value; }  // set method
        }
        public Company(List<Employee> employees) {
            this.employees = employees;
        }
        public double TotalPayroll(DateTime localDate) {
            double total = 0;
            foreach (var item in employees)
            {
                total += item.CalculatePay(localDate);
            }
            return total;
        }
    }
}
