using System;
using static System.Console;
using System.Globalization;
class GuessingGame
{
	static void Main()
	{
		Random ranNumberGenerator = new Random();
		int randomNumber, user_guess;
		randomNumber = ranNumberGenerator.Next(1, 10);
		Write("Guess a number from 1 - 10: ");
		user_guess = Convert.ToInt32(ReadLine());
		if(user_guess > randomNumber){
			WriteLine("Too high");
		}
		if(user_guess < randomNumber){
			WriteLine("Too low");
		}
		if(user_guess == randomNumber){
			WriteLine("Correct");
		}
		WriteLine(randomNumber);
	}
}
