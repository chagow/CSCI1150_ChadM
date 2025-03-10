using System;
using static System.Console;
using System.Globalization;
class DeliveryCharges
{
	static void Main()
	{
		string[] zips = {"12789", "54012", "54481", "54982", "60007",
	         "60103", "60187", "60188", "71244", "90210"};
		double[] prices = {15.60, 20, 59.99, 10.39, 3.00,
	         32.00, 24.99, 25.00, 16, 10};
	
		string userInput;
	        double zipPrice = 0;
	        bool check = false;
	        WriteLine("Enter a valid zip code: ");
	        userInput = ReadLine();
	        for(int i = 0; i < zips.Length; i++){
	            if(userInput == zips[i]){
	                zipPrice = prices[i];
	                check = true;
	                break;
	            }
	            else{
	                check = false;
	            }
	        }
	        if(check == true){
	            WriteLine("Delivery to "+userInput+" ok. Delivery charge is {0}",
	                zipPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	        } else{
	            WriteLine("Sorry - no delivery to "+userInput);
	        }
	}
}
