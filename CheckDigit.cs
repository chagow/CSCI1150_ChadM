using System;
using static System.Console;
using System.Globalization;
class CheckDigit
{
	static void Main()
	{
		int user_acc, dividend, remainder;
		Write("Enter your four-dight account number: ");
		user_acc = Convert.ToInt32(ReadLine());
		string acc_dividend = Convert.ToString(user_acc).Substring(0, 3);
		dividend = Convert.ToInt32(acc_dividend);
		remainder = dividend % 7;
		string acc_remainder = Convert.ToString(remainder);
		string acc_size = Convert.ToString(user_acc);
		WriteLine(remainder);
		WriteLine(acc_remainder);
		WriteLine(acc_size);
		if (acc_size.Length > 4 || acc_size.Length < 4){
			WriteLine("Account number invalid - it must have 4 digits.");
		} else{
			if(acc_size.EndsWith(acc_remainder)){
				WriteLine("The account number is valid");
			} else{
				WriteLine("Invalid");
			}
		}
	}
}
