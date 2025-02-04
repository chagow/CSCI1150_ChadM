using System;
using static System.Console;
using System.Globalization;
class Planets
{
	enum Planet
	{
		Mercury = 1, Venus = 2, Earth = 3, Mars = 4, Jupiter = 5, Saturn = 6, Uranus = 7, Neptune = 8
	}
	static void Main()
	{
		Write("Enter planet number: ");
		int usernum = Convert.ToInt32(ReadLine());
		Planet planet = (Planet)Convert.ToInt32(usernum);
		WriteLine(planet+ " is " +usernum+ " planet(s) from the sun");
	}
}
