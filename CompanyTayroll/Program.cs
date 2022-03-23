using System;
using System.Collections.Generic;
using payroll;

namespace CompanyTayroll
{
    class Program
    {
        static void Main(string[] args)
        {            

            Manager manager1 = new Manager("Manager 1", new DateTime(2020, 3, 1), 1000);
            Manager manager2 = new Manager("Manager 2", new DateTime(2010, 3, 1), 1000, manager1);
            Manager manager3 = new Manager("Manager 3", new DateTime(1990, 3, 1), 1000);


            Seller seller1 = new Seller("Seler 1", new DateTime(2020, 3, 1), 100, manager1);
            Seller seller2 = new Seller("Seler 2", new DateTime(2015, 3, 1), 100, manager1);
            Seller seller3 = new Seller("Seler 3", new DateTime(2010, 3, 1), 100, seller1);
            Seller seller4 = new Seller("Seler 4", new DateTime(2005, 3, 1), 100, seller1);
            Seller seller5 = new Seller("Seler 5", new DateTime(2000, 3, 1), 100, seller2);
            Seller seller6 = new Seller("Seler 6", new DateTime(1995, 3, 1), 100, manager2);

            Employee employee1 = new Employee("Employee 1", new DateTime(2020, 3, 1), 100, manager3);
            Employee employee2 = new Employee("Employee 2", new DateTime(2018, 3, 1), 100, manager3);
            Employee employee3 = new Employee("Employee 3", new DateTime(2000, 3, 1), 100, manager3);
            Employee employee4 = new Employee("Employee 4", new DateTime(2008, 3, 1), 100, manager3);
            Employee employee5 = new Employee("Employee 5", new DateTime(1990, 3, 1), 100, manager2);
            Employee employee6 = new Employee("Employee 6", new DateTime(1985, 3, 1), 100, manager2);
            Employee employee7 = new Employee("Employee 7", new DateTime(2020, 3, 1), 100, seller1);
            Employee employee8 = new Employee("Employee 8", new DateTime(2018, 3, 1), 100, seller1);
            Employee employee9 = new Employee("Employee 9", new DateTime(2000, 3, 1), 100, manager1);
            Employee employee10 = new Employee("Employee 10", new DateTime(2008, 3, 1), 100, manager1);
            Employee employee11 = new Employee("Employee 11", new DateTime(1990, 3, 1), 100, manager1);
            Employee employee12= new Employee("Employee 12", new DateTime(1985, 3, 1), 100,seller1);

            manager1.Subordinates = new List<Employee>{ manager2, seller1, seller2, employee9, employee10, employee11 };
            manager2.Subordinates = new List<Employee> { seller6, employee5, employee6 };
            manager3.Subordinates = new List<Employee> { employee1, employee2, employee3, employee4 };
            seller1.Subordinates= new List<Employee> { seller3, seller4, employee7, employee8, employee12 };
            seller2.Subordinates = new List<Employee> { seller5 };

            Company company = new Company(new List<Employee> {
            manager1,manager2,manager3,
            seller1,seller2,seller3,seller4,seller5,seller6,
            employee1,employee2,employee3,employee4,employee5,employee6,employee7,employee8,employee9,employee10,employee11,employee12});

            DateTime date = DateTime.Today;

            Console.WriteLine("Total to pay  " + company.TotalPayroll(date));
            Console.WriteLine("Total to pay employee1 " + employee1.CalculatePay(date));
            Console.WriteLine("Total to pay employee3 " + employee3.CalculatePay(date));
            Console.WriteLine("Total to pay seller1 " + seller1.CalculatePay(date));
            Console.WriteLine("Total to pay seller6 " + seller6.CalculatePay(date));
            Console.WriteLine("Total to pay manager3 " + manager3.CalculatePay(date));
            Console.ReadLine();
        }
    }
}
