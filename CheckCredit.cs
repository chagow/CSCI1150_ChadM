using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
	static void Main()
	{
		int user_number;
		Write("How much money are you spending?: ");
		user_number = Convert.ToInt32(ReadLine());
		if (user_number > 8000){
			WriteLine("You have exceeded the credit limit");
		} else{
			WriteLine("Approved");
		}
	}
}
