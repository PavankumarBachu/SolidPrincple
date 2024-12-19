using System;
namespace SolidPrincple
{
	public class EmployeeFinances
	{
        public double CalculatePay(Employee e)
        {
            if(e.employeeType == emptype.FullType.ToString())
            {
                return e.TotalHoursWorked * 10;
            }
            if (e.employeeType == emptype.PartTime.ToString())
            {
                return e.TotalHoursWorked * 5; 
            }

            return 10;
        }
    }
}

