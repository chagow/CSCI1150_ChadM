using System;
using static System.Console;
using System.Globalization;
class FineForOverdueBooks
{
	public static double DisplayFine(int days, int books)
	{
		int over7Days = 0;
		if(days > 7){
			over7Days = days - 7;
			days -= over7Days;
		}
		double bookDays = Convert.ToDouble(books * days);
		double overBookDays = Convert.ToDouble(books * over7Days);
		const double Price = 0.10;
		const double afterweekPrice = 0.20;
		double cost = bookDays * Price;
		double aftercost = overBookDays * afterweekPrice;
		double totalCost = cost + aftercost;
		return totalCost;
	}
	static void Main()
	{
		Write("How many books have you checked out: ");
		int books = Convert.ToInt32(ReadLine());
		Write("How many days have they been overdue: ");
		int days = Convert.ToInt32(ReadLine());
		// The code here is turning the method into a variable. I use the Cengage Companion in case I am missing something.
		// However, it kept printing "str - AssertionError" no matter what tricks I tried.
		double printCost = DisplayFine(days, books);
		string printStatement = Convert.ToString("The fine for "+books+" book(s) for "+days+" day(s) is "+printCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine(printStatement);
	}
}
