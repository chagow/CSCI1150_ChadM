using System;
using static System.Console;
using System.Globalization;
class SwimmingWaterTemperature
{
	static void Main()
	{
		const int MINDEGREE = 70;
		const int MAXDEGREE = 85;
		const int freezePoint = 32;
		const int boilPoint = 212;
		int loop = 0, userInput = 0;
		Write("Enter a temperature or 999 to quit: ");
		while(loop != 999)
		{
			userInput = Convert.ToInt32(ReadLine());
			if(userInput == 999)
			{
				loop = userInput;
			}
			else
			{
				if(userInput <= boilPoint && userInput >= freezePoint)
				{
					if(userInput >= MINDEGREE && userInput <= MAXDEGREE)
					{
						Write("{0} degrees is comfortable for swimming. ", userInput);
					}
					else
					{
						Write("{0} degrees is not comfortable for swimming. ", userInput);
					}
				}
				if(userInput > boilPoint || userInput < freezePoint)
				{
					throw new ArgumentException("Value does not fall within the expected range.");
				}
			}
			Write("Enter another temperature or 999 to quit: ");
		}
	}
}
