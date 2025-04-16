using System;
using static System.Console;
using System.Globalization;
class SubscriptExceptionTest
{
	static void Main()
	{
		int loop = 0, userInput = 0;
		double[] testArray = {20.3, 2, 3, 4, 5, 67.5, 7, 14.6, 9, 10};
		try
		{
			while(loop != 99)
			{
				Write("Which of the 10 values would you like to see? (Enter 99 to quit): ");
				userInput = Convert.ToInt32(ReadLine());
				if(userInput != 99)
				{
					Write("Index {0}: {1,-5}", userInput, testArray[userInput]);
				}
				else
				{
					if(userInput == 99){
						loop = userInput;
					}
				}
			}
		}
		catch(Exception anExceptionInstance)
		{
			WriteLine(anExceptionInstance.ToString());
			WriteLine("Index {0} was outside the bounds of the array.", userInput);
		}
	}
}
