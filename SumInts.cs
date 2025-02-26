using System;
using static System.Console;
using System.Globalization;
class SumInts
{
	static void Main()
	{
		int sum = 0;
		int user_number;
		int loops = 0;
		while (loops == 0){
			WriteLine("Enter a number,\nEntering 999 quits the program: ");
			user_number = Convert.ToInt32(ReadLine());
			if(user_number == 999){
				WriteLine("Total sum, not including 999: "+sum);
				loops += 1;
			} else {
				sum += user_number;
				WriteLine("Current sum: "+sum);
			}
		}
	}
}
