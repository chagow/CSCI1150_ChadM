using System;
using static System.Console;
using System.Globalization;
class CountVowelsModularized
{
	static void Main()
	{
		string input, vowelResult;
		Write("Insert a phrase: ");
		input = ReadLine();
		vowelResult = CountVowels(input);
		WriteLine("Total amount of vowels: "+vowelResult);
	}
	public static string CountVowels(string input)
	{
		string total = "";
		int counter = 0;
		string lowered = input.ToLower();
		for(int i = 0; i < lowered.Length; i++){
			if(lowered[i] == 'a' || lowered[i] == 'e' || lowered[i] == 'i' || lowered[i] == 'o' || lowered[i] == 'u'){
				counter += 1;
			}
		}
		total = Convert.ToString(counter);
		return total;
	}
}
