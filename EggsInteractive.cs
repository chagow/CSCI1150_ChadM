using System;
using static System.Console;
using System.Globalization;
class EggsInteractive
{
	static void Main()
	{
		int chicken1, chicken2, chicken3, chicken4 ;
		Write("How many eggs did chicken 1 lay? ");
		chicken1 = Convert.ToInt32(ReadLine());
		Write("How many eggs did chicken 2 lay? ");
		chicken2 = Convert.ToInt32(ReadLine());
		Write("How many eggs did chicken 3 lay? ");
		chicken3 = Convert.ToInt32(ReadLine());
		Write("How many eggs did chicken 4 lay? ");
		chicken4 = Convert.ToInt32(ReadLine());
		const int todozen = 12;
		int totalegg = chicken1 + chicken2 + chicken3 + chicken4;
		int dozen = totalegg / todozen;
		int realegg = totalegg - todozen * dozen;
		WriteLine(totalegg+ " eggs is " +dozen+ " dozen and " +realegg+ " eggs");
	}
}
