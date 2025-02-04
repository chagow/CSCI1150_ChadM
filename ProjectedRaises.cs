using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
	static void Main()
	{
		const double raise = 0.04;
		double emp1 = 25000 + 25000 * raise;
		double emp2 = 38000 + 38000 * raise;
		double emp3 = 51000 + 51000 * raise;

		WriteLine("Next year's salary for the first employee will be {0}", emp1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the second employee will be {0}", emp2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the third employee will be {0}", emp3.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
