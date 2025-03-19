using System;
using static System.Console;
using System.Globalization;
class FortuneTeller
{
	public static void Fortune(string chosenFortune, string chosenFortune2)
	{
		WriteLine(chosenFortune);
		WriteLine("Also, {0}", chosenFortune2);
	}

	static void Main()
	{
		string[] fortuneTells = {"I see a tall dark stranger in your future.",
		"You will lose a hundred bucks if you can't pay me.",
		"You will haunted by the ghost of Claus Santa.",
		"I can see that you will find a close friend in the near future.",
		"I sense that the future of the world lies on your shoulder. ",
		"You may win a lottery around 500 to 1000 dollars. "};

		Random ranNumberGenerator = new Random();
		int randomNumber = ranNumberGenerator.Next(0, 5);
		int randomNumber2 = ranNumberGenerator.Next(0, 5);
		int loop = 0;
		while(loop == 0){
			if(randomNumber == randomNumber2){
				randomNumber2 = ranNumberGenerator.Next(0, 5);
			} else{
				string chosenFortune = fortuneTells[randomNumber];
				string chosenFortune2 = fortuneTells[randomNumber2];
				Fortune(chosenFortune, chosenFortune2);
				loop = 1;
			}
		}
	}
}
