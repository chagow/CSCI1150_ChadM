using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
	static void Main()
	{
		int user_wind;
		Write("What is the windspeed of the Hurricane?: ");
		user_wind = Convert.ToInt32(ReadLine());
		if (user_wind < 74){
			WriteLine("This is not a hurricane ");
		} else{
			if(user_wind < 96 && user_wind >= 74){
				WriteLine("This is a category 1 hurricane ");
			}
			if(user_wind < 111 && user_wind >= 96){
				WriteLine("This is a category 2 hurricane ");
			}
			if(user_wind < 130 && user_wind >= 111){
				WriteLine("This is a category 3 hurricane ");
			}
			if(user_wind < 157 && user_wind >= 130){
				WriteLine("This is a category 4 hurricane ");
			}
			if(user_wind >= 157){
				WriteLine("This is a category 5 hurricane ");
			}
		}
	}
}
