using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
	static void Main()
	{
		string[] nameList = {"Danielle", "Edward", "Francis"};
	        string[] initialsList = {"D", "E", "F"};
	        double[] sales = new double [3];
		double input;
	        int nameCheck = nameList.Length - 1;
	        bool dsales = false, esales = false, fsales = false, salesTie = false;
		double total = 0;
		int loop = 0;
	        string quit;
		while(loop == 0){
	            total = 0;
	            for(int i = 0; i < sales.Length; i++){
			        Write("Enter the sales for salesman {0}: ", initialsList[i]);
	                input = Convert.ToDouble(ReadLine());
	                total += input;
	                sales[i] = input;
	            }
	            Write("Are those the final values? (Y/N): ");
	            quit = ReadLine().ToUpper();
	            if(quit == "Y"){
	                loop = 1;
	            }
		}
	        for(int i = 0; i < nameList.Length; i++){
	            WriteLine("{0} sold {1}", 
	            nameList[i],
	            sales[i].ToString("C", CultureInfo.GetCultureInfo("en-US")));
	        }
	        WriteLine("Total sales were {0}",
	            total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	        for(int i = 0; i < (sales.Length - 1); i++){
	            if(sales[0] > sales[1] && sales[0] > sales[2]){
	                dsales = true;
	                break;
	            }
	            if(sales[1] > sales[0] && sales[1] > sales[2]){
	                esales = true;
	                break;
	            }
	            if(sales[2] > sales[0] && sales[2] > sales[1]){
	                fsales = true;
	                break;
	            }
	            if(sales[i] == sales[i+1]){
	                salesTie = true;
	                break;
	            }
	        }

		if(dsales == true){
			WriteLine("Danielle sold the most");
		}
		if(esales == true){
			WriteLine("Edward sold the most");
		}
		if(fsales == true){
			WriteLine("Francis sold the most");
		}
		if(salesTie == true){
			WriteLine("There was a tie");
		}
	}
}
