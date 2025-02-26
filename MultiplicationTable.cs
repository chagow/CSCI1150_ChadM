using System;
using static System.Console;
using System.Globalization;
class MultiplicationTable
{
	static void Main()
	{
		int input;
		Write("Enter an integer: ");
		input = Convert.ToInt32(ReadLine());
		for(int i = 1; i <= 10; i++){
			Write(i+" x " +input+ " = " +input * i +", ");
		}
	}
}
