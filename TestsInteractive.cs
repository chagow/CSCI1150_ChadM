using System;
using static System.Console;
using System.Globalization;
class TestsInteractive
{
	static void Main()
	{
		Write("Enter test score 1 >> ");
		double t1 = Convert.ToDouble(ReadLine());
		Write("Enter test score 2 >> ");
		double t2 = Convert.ToDouble(ReadLine());
		Write("Enter test score 3 >> ");
		double t3 = Convert.ToDouble(ReadLine());
		Write("Enter test score 4 >> ");
		double t4 = Convert.ToDouble(ReadLine());
		Write("Enter test score 5 >> ");
		double t5 = Convert.ToDouble(ReadLine());
		Write("Enter test score 6 >> ");
		double t6 = Convert.ToDouble(ReadLine());
		Write("Enter test score 7 >> ");
		double t7 = Convert.ToDouble(ReadLine());
		Write("Enter test score 8 >> ");
		double t8 = Convert.ToDouble(ReadLine());

		double average = (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8) / 8;
		double rounded = Math.Round(average, 2, MidpointRounding.AwayFromZero);
		WriteLine("The average test score is " +rounded);
	}
}
