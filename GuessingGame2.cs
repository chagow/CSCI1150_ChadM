using System;
using static System.Console;
using System.Globalization;
class GuessingGame2
{
	static void Main()
	{
		Random ranNumberGenerator = new Random();
		int randomNumber, user_guess;
		int loop = 0;
		randomNumber = ranNumberGenerator.Next(1, 10);
		Write("Guess a number from 1 - 10: ");
		while(loop == 0){
			user_guess = Convert.ToInt32(ReadLine());
			if(user_guess == randomNumber){
				WriteLine("Correct");
				loop += 1;
			} else{
				Write("Incorrect, guess again: ");
			}
		}
	}
}
