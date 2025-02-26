using System;
using static System.Console;
using System.Globalization;
class EnterUppercaseLetters
{
	static void Main()
	{
		string begin_user, uppercase_user;
		int loop = 0;
		while (loop == 0){
			WriteLine("Enter an uppercase letter or ! to quit");
			uppercase_user = Convert.ToString(ReadLine());
			if(uppercase_user.Length == 1 && (char.IsUpper(uppercase_user, 0) || uppercase_user.Equals("!"))){
				WriteLine("OK");
				loop += 1;
			} else{
				WriteLine("Sorry - that was not an uppercase letter. ");
			}	
		}
	}
}
