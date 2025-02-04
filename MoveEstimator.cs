using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
	static void Main()
	{
		const double move = 200;
		const double perhour = 150;
		const double permile = 2;

		Write("Enter number of hours: ");
		double userhour = Convert.ToDouble(ReadLine());
		Write("Enter number of miles: ");
		double usermile = Convert.ToDouble(ReadLine());

		double hourcost = userhour * perhour;
		double milecost = usermile * permile;
		double total = move + hourcost + milecost;

		Write("For a move taking ");
		Write(userhour);
		Write(" hours and going ");
		Write(usermile);
		Write(" miles the estimate is ");
		WriteLine("{0}", total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
