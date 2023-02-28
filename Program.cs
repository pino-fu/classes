using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Test Company", DateTime.Now);

            Employee employee1 = new Employee()
            {
                FirstName = "Jeff",
                Lastname = "Jefferson",
                Title = "Boss",
                Date = DateTime.Now
            };
            Employee employee2 = new Employee()
            {
                FirstName = "Jim",
                Lastname = "Jimmerson",
                Title = "Janitor",
                Date = DateTime.Now
            };
            Employee employee3 = new Employee()
            {
                FirstName = "Bill",
                Lastname = "Billerson",
                Title = "Billing",
                Date = DateTime.Now
            };

            // Assign the employees to the company

            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.ListEmployees();
        }
    }
}