using System;
using static System.Console;
using System.Globalization;
class PigLatin
{
	static void Main()
	{
		Write("Enter a word: ");
		string userword = ReadLine();
		string firstletter = userword.Substring(0, 1);
		string leftover = userword.Substring(1, userword.Length - 1);
		WriteLine(leftover+firstletter+"ay");
	}
}
