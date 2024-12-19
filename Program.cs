using System;

namespace SolidPrincple
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empFtp = new Employee()
            {
                employeeType = emptype.FullType.ToString(),
                TotalHoursWorked = 10
            };
            Employee empPte = new Employee()
            {
                employeeType = emptype.PartTime.ToString(),
                TotalHoursWorked = 10
            };

            EmployeeFinances employeeFinances = new EmployeeFinances();
            var totalPay = employeeFinances.CalculatePay(empFtp);
            Console.WriteLine(totalPay);
            Console.Read();
        }
    }
}