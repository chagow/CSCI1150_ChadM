using System;
using static System.Console;
using System.Globalization;
class FahrenheitToCelsius
{
	static void Main()
	{
		Write("Enter a temperature in fahrenheit: ");
		double usertemp = Convert.ToDouble(ReadLine());
		double tocelsius = 5.0 / 9.0;
		double subcels = usertemp - 32;
		double convcels = subcels * tocelsius;
		Write($"{Math.Round(usertemp, 1):0.0} F is "); 
		WriteLine($"{Math.Round(convcels, 1):0.0} C");
	}
}
