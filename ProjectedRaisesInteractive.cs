using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
	static void Main()
	{
		Write("Enter the salary for employee 1: ");
		double empone = Convert.ToDouble(ReadLine());
		Write("Enter the salary for employee 2: ");
		double emptwo = Convert.ToDouble(ReadLine());
		Write("Enter the salary for employee 3: ");
		double empthr = Convert.ToDouble(ReadLine());
		const double raise = 0.04;

		double emp1 = empone + empone * raise;
		double emp2 = emptwo + emptwo * raise;
		double emp3 = empthr + empthr * raise;

		WriteLine("Next year's salary for the first employee will be {0}", emp1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the second employee will be {0}", emp2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the third employee will be {0}", emp3.ToString("C", CultureInfo.GetCultureInfo("en-US")));

	}
}
