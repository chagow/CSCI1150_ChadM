using System;
using static System.Console;
using System.Globalization;
class MonthNames
{
	enum Month
	{
		JANUARY = 1, FEBRUARY = 2, MARCH = 3, APRIL = 4, MAY = 5, JUNE = 6, JULY = 7, AUGUST = 8, SEPTEMBER = 9, OCTOBER = 10, NOVEMBER = 11, DECEMBER = 12
	}
	static void Main()
	{
		Write("Enter month number: ");
		int usernum = Convert.ToInt32(ReadLine());
		Month month = (Month)Convert.ToInt32(usernum);
		WriteLine(month);
	}
}
