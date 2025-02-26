using System;
using static System.Console;
using System.Globalization;
class GuessingGame3
{
	static void Main()
	{
		Random ranNumberGenerator = new Random();
		int randomNumber, user_guess;
		int again = 0;
		int loop = 0;
		randomNumber = ranNumberGenerator.Next(1, 10);
		Write("Guess a number from 1 - 10: ");
		while(loop == 0){
			user_guess = Convert.ToInt32(ReadLine());
			if(user_guess == randomNumber){
				WriteLine("Correct");
				loop += 1;
			}
			if(user_guess > randomNumber){
				if(again == user_guess){
					WriteLine("You already knew it was not "+again+" or more");
				}
				WriteLine("Your guess was too high");
				again = user_guess;
			}
			if(user_guess < randomNumber){
				if(again == user_guess){
					WriteLine("You already knew it was not "+again+" or less");
				}
				WriteLine("You guess was too low");
				again = user_guess;
			}
		}
	}
}
