using System;
using static System.Console;
using System.Globalization;
class HoursAndMinutes
{
	static void Main()
	{
		const double minhour = 60;
		double minutes = 197;
		double hour = Math.Floor(minutes / minhour);
		double realminutes = minutes - minhour * hour;
		WriteLine(minutes+ " minutes is " +hour+ " hours and " +realminutes+ " minutes");
	}
}
