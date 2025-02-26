using System;
using static System.Console;
using System.Globalization;
class CountVowels
{
	static void Main()
	{
		string input, lowered;
		int total = 0;
		Write("Insert a phrase: ");
		input = ReadLine();
		lowered = input.ToLower();
		for(int i = 0; i < lowered.Length; i++){
			if(lowered[i] == 'a' || lowered[i] == 'e' || lowered[i] == 'i' || lowered[i] == 'o' || lowered[i] == 'u'){
				total++;
			}
		}
		WriteLine("Total amount of vowels: {0}", total);
	}
}
