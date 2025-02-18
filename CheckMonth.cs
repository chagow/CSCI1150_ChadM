using System;
using static System.Console;
using System.Globalization;
class CheckMonth
{
	static void Main()
	{
		int user_month;
		WriteLine("Enter the number of your birth month: ");
		user_month = Convert.ToInt32(ReadLine());
		if(user_month > 12 || user_month < 1){
			WriteLine("Invalid month");
		} else{
			WriteLine(user_month+" is a valid month");
		}
	}
}
