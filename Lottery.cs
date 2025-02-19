using System;
using static System.Console;
using System.Globalization;
class Lottery
{
	static void Main()
	{
		Random ranNumberGenerator = new Random();
		int randomNumber1, randomNumber2, randomNumber3, user_one, user_two, user_three;
		string totalNumber, userNumber;
		randomNumber1 = ranNumberGenerator.Next(1, 4);
		randomNumber2 = ranNumberGenerator.Next(1, 4);
		randomNumber3 = ranNumberGenerator.Next(1, 4);
		totalNumber = String.Format("{0}{1}{2}", randomNumber1, randomNumber2, randomNumber3);
		Write("Guess your first number from 1 - 4: ");
		user_one = Convert.ToInt32(ReadLine());
		Write("Guess your second number from 1 - 4: ");
		user_two = Convert.ToInt32(ReadLine());
		Write("Guess your third number from 1 - 4: ");
		user_three = Convert.ToInt32(ReadLine());
		userNumber = String.Format("{0}{1}{2}", user_one, user_two, user_three);
		
		WriteLine("The correct answer was: "+totalNumber);
		WriteLine("You guessed: "+userNumber);
		
		if(userNumber.Contains(totalNumber)){
			WriteLine("You won $10,000");
		} else{
			if(totalNumber.Contains(user_one.ToString()) && totalNumber.Contains(user_two.ToString())
			&& totalNumber.Contains(user_three.ToString())){
				WriteLine("You won $1,000");
			} else{
				if(totalNumber.Contains(user_one.ToString()) && totalNumber.Contains(user_two.ToString())
				|| totalNumber.Contains(user_two.ToString()) && totalNumber.Contains(user_three.ToString())
				|| totalNumber.Contains(user_one.ToString()) && totalNumber.Contains(user_three.ToString())){
					WriteLine("You won $1000");
				} else{
					if(totalNumber.Contains(user_one.ToString()) || totalNumber.Contains(user_two.ToString()) 
					|| totalNumber.Contains(user_one.ToString()) ){
						WriteLine("You won $10");
					} else{
						WriteLine("You won $0");
					}
				}
			}
		}
	}
}
