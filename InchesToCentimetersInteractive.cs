using System;
using static System.Console;
using System.Globalization;
class InchesToCentimetersInteractive
{
	static void Main()
	{
		Write("Enter a number: ");
		double inches = Convert.ToDouble(ReadLine());
		const double tocent = 2.54;
		double convert = inches * tocent;
		Write(inches);
		Write(" inches is ");
		Write(convert);
		WriteLine(" centimeters");
	}
}
