using System;
using static System.Console;
using System.Globalization;
class MakeChange
{
	static void Main()
	{
		Write("Enter an amount of dollars: ");
		int userdoll = Convert.ToInt32(ReadLine());
		int twenty = Convert.ToInt32(userdoll / 20);
		int ten = Convert.ToInt32((userdoll - 20 * twenty) / 10);
		int five = Convert.ToInt32((userdoll - 20 * twenty - 10 * ten) / 5);
		int one = Convert.ToInt32((userdoll - 20 * twenty - 10 * ten - 5 * five) / 1);

		WriteLine("twenties: " +twenty+ " tens: " +ten+ " fives: " +five+ " ones: " +one);
	}
}
