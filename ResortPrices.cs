using System;
using static System.Console;
using System.Globalization;
class ResortPrices
{
	static void Main()
	{
	    double[] preNights = {1, 3, 5, 8};
	    double[] perNightCost = {200, 180, 160, 145};
	    int nightCheck = preNights.Length - 1;
	    double userNights = 0;
	    double totalCost;
	    Write("How many nights are you staying: ");
	    userNights = Convert.ToDouble(ReadLine());
	    while(nightCheck >= 0 && userNights < preNights[nightCheck]){
	        --nightCheck;
	    }
	    totalCost = perNightCost[nightCheck] * userNights;
	    WriteLine("Price per night is {0}\nTotal for {1} night(s) is {2}",
            perNightCost[nightCheck].ToString("C", CultureInfo.GetCultureInfo("en-US")),
            userNights,
            totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
