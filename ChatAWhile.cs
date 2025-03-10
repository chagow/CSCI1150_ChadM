using System;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
	static void Main()
	{
		string[] areaCode = {"262", "414", "608", "715", "815", "920"};
		double[] prices = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};

		string userArea;
	        double userMinutes, areaPrice = 0;
	        bool check = false;
	        Write("Enter a valid area code: ");
	        userArea = ReadLine();
	        for(int i = 0; i < areaCode.Length; i++){
	            if(userArea == areaCode[i]){
	                areaPrice = prices[i];
	                check = true;
	                break;
	            }
	            else{
	                check = false;
	            }
	        }
	
	        if(check == true){
	            Write("How many minutes are you taking: ");
	            userMinutes = Convert.ToDouble(ReadLine());
	            double totalPrice = userMinutes * areaPrice;
	            WriteLine("Your phone call to area "+userArea+" costs {0} per minute\nFor {1} minutes the total is {2}",
	                areaPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")),
	                userMinutes,
	                totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	        } else{
	            WriteLine("Sorry - no delivery to "+userArea);
	        }
	}
}
