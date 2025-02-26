using System;
using static System.Console;
using System.Globalization;
class DailyTemps
{
	static void Main()
	{
		double tempinput, tempavg;
		double tempsum = 0;
		double tempamount = 0;
		double loop = 0;
		WriteLine("Valid temperatures range from -20 to 130, Enter a temperature number (Enter 999 to quit): ");
		while (loop == 0){
			tempinput = Convert.ToDouble(ReadLine());
			if (tempinput == 999){
				tempavg = tempsum / tempamount;
				WriteLine("You have inputted: "+tempamount+" temperatures that averages: "+tempavg);
				loop += 1;
			} else{
				if(tempinput < -20 || tempinput > 130){
					WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature. ");
				} else{
					tempamount++;
					tempsum += tempinput;
					WriteLine("Current amount: "+tempamount+"\nCurrent sum: "+tempsum);
				}
			} 
		}
	}
}
