using System;
using static System.Console;
using System.Globalization;
class RockPaperScissors
{
	static void Main()
	{
		Random ranNumberGenerator = new Random();
		int randomNumber;
		string user_rps;
		randomNumber = ranNumberGenerator.Next(1, 3);
		Write("Input 'r'(Rock), 'p'(Paper), 's'(Scissors): ");
		user_rps = Convert.ToString(ReadLine());
		switch(user_rps){
			case "r":
			if(randomNumber == 1){
				WriteLine("Tie, Rock vs Rock");
			}
			if(randomNumber == 2){
				WriteLine("Lose, Rock vs Paper");
			}
			if(randomNumber == 3){
				WriteLine("Win, Rock vs Scissors");
			}
			break;
			case "p":
			if(randomNumber == 1){
				WriteLine("Win, Paper vs Rock");
			}
			if(randomNumber == 2){
				WriteLine("Tie, Paper vs Paper");
			}
			if(randomNumber == 3){
				WriteLine("Lose, Paper vs Scissors");
			}
			break;
			case "s":
			if(randomNumber == 1){
				WriteLine("Lose, Scissors vs Rock");
			}
			if(randomNumber == 2){
				WriteLine("Win, Scissors vs Paper");
			}
			if(randomNumber == 3){
				WriteLine("Tie, Scissors vs Scissors");
			}
			break;
			default:
			WriteLine("Invalid choice");
			break;
		}
	}
}
