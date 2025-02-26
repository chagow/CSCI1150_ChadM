using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
	static void Main()
	{
		int sum = 0;
		int total = 0;
		WriteLine("Enter 5 numbers: ");
		do
		{
			sum = sum + (Convert.ToInt32(ReadLine()));
			total += 1;
		} while(total < 5);
		WriteLine("Total sum: "+sum);
	}
}
