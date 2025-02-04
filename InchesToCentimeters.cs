using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double tocent = 2.54;
		double inch = 3;
		double convert = inch * tocent;
		Write(inch);
		Write(" inches is ");
		Write(convert);
		WriteLine(" centimeters");
	}
}
