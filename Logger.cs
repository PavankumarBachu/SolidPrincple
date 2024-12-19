using System;
namespace SolidPrincple
{
	public class Logger
	{
		public void	LogError(String Message)
		{
            System.IO.File.WriteAllText("/Users/pavankumar/Projects/log.txt", Message);
        }
	}
}

