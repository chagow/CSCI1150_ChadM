using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
	static void Main()
	{
		const double raise = 0.04;
		Write("Enter the salary for employee 1: ");
		double emp1 = Convert.ToDouble(ReadLine());
		Write("Enter the salary for employee 2: ");
		double emp2 = Convert.ToDouble(ReadLine());
		Write("Enter the salary for employee 3: ");
		double emp1 = Convert.ToDouble(ReadLine());

		WriteLine("Next year's salary for the first employee will be {0}", emp1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the second employee will be {0}", emp2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the third employee will be {0}", emp3.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
