using System;
using static System.Console;
using System.Globalization;
class ConvertMilesToKilometers
{
	public static double ConvertToKilometers(double userMiles)
	{
		double toKilo = 1.60934;
		double kiloCalc = userMiles * toKilo;
		return kiloCalc;
	}

	static void Main()
	{
		Write("Enter number of miles: ");
		double userMiles = Convert.ToDouble(ReadLine());
		double kiloCount = ConvertToKilometers(userMiles);
		WriteLine("{0} miles is {1} kilometers. ", userMiles, kiloCount);
	}
}
