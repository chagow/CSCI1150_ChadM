using System;
using static System.Console;
using System.Globalization;
class Twitter
{
	static void Main()
	{
		string user_input;
		WriteLine("Write a message: ");
		user_input = Convert.ToString(ReadLine());
		if (user_input.Length < 140){
			WriteLine("The message is okay");
		} else{
			WriteLine("The message is too long");
		}
	}
}
