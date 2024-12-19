using System;
namespace SolidPrincple
{
	public class Employee
	{
		public string employeeType { get; set; }
		public double TotalHoursWorked { get; set; }

		public void Save(Employee e)
		{
			try
			{

			}
			catch(Exception ex)
			{
				//throw;
				Logger logger = new Logger();
				logger.LogError(ex.Message);
			}
		}
		
	}

	public enum emptype
	{
		FullType,
		PartTime
	}
}

