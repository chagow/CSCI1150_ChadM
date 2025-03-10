using System;
using static System.Console;
using System.Globalization;
class CheckZips
{
	static void Main()
	{
		string[] zips = {"12789", "54012", "54481", "54982", "60007",
	        "60103", "60187", "60188", "71244", "90210"};
			
		string userInput;
	        bool check = false;
	        WriteLine("Enter a valid zip code: ");
	        userInput = ReadLine();
	        for(int i = 0; i < zips.Length; i++){
	            if(userInput == zips[i]){
	                check = true;
	                break;
	            }
	            else{
	                check = false;
	            }
	        }
	        if(check == true){
	            WriteLine("Delivery to "+userInput+" ok");
	        } else{
	            WriteLine("Sorry - no delivery to "+userInput);
	        }
	}
}
