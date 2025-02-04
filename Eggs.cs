using System;
using static System.Console;
using System.Globalization;
class Eggs
{
	static void Main()
	{
		int chicken1 = 32, chicken2 = 28, chicken3 = 17, chicken4 = 50;
		const int todozen = 12;
		int totalegg = chicken1 + chicken2 + chicken3 + chicken4;
		int dozen = totalegg / todozen;
		int realegg = totalegg - todozen * dozen;
		WriteLine(totalegg+ " eggs is " +dozen+ " dozen and " +realegg+ " eggs");
	}
}
