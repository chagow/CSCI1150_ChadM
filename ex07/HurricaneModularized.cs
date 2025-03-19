using System;
using static System.Console;
using System.Globalization;
class HurricaneModularized
{
	static void Main()
	{
		int user_wind;
		Write("What is the windspeed of the Hurricane?: ");
		user_wind = Convert.ToInt32(ReadLine());
		string hurricaneResult = HurricaneScale(user_wind);
		WriteLine(hurricaneResult);
	}
	public static string HurricaneScale(int user_wind)
	{
		string hurricaneCategory = "";
		if (user_wind < 74){
			hurricaneCategory = "This is not a hurricane ";
		} else{
			if(user_wind < 96 && user_wind >= 74){
				hurricaneCategory = "This is a category 1 hurricane ";
			}
			if(user_wind < 111 && user_wind >= 96){
				hurricaneCategory = "This is a category 2 hurricane ";
			}
			if(user_wind < 130 && user_wind >= 111){
				hurricaneCategory = "This is a category 3 hurricane ";
			}
			if(user_wind < 157 && user_wind >= 130){
				hurricaneCategory = "This is a category 4 hurricane ";
			}
			if(user_wind >= 157){
				hurricaneCategory = "This is a category 5 hurricane ";
			}
		}
		return hurricaneCategory;
	}
}
