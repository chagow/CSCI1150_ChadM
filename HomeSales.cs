using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
	static void Main()
	{
		string input, quickfix;
		double dsales = 0;
		double esales = 0; 
		double fsales = 0;
		double total = 0;
		int loop = 0;
		Write("Enter a salesperson initial: ");
		while(loop == 0){
		input = ReadLine();
		quickfix = input.ToUpper();
		switch(quickfix){
				case "D":
				Write("Enter amount of sale: ");
				dsales += Convert.ToDouble(ReadLine());
				Write("Enter next salesperson intital or Z to quit: ");
				break;

				case "E":
				Write("Enter amount of sale: ");
				esales += Convert.ToDouble(ReadLine());
				Write("Enter next salesperson intital or Z to quit: ");
				break;

				case "F":
				Write("Enter amount of sale: ");
				fsales += Convert.ToDouble(ReadLine());
				Write("Enter next salesperson intital or Z to quit: ");
				break;

				case "Z":
				WriteLine("Danielle sold	{0}\nEdward sold	{1}\nFrancis sold	{2}", 
				dsales.ToString("C", CultureInfo.GetCultureInfo("en-US")), 
				esales.ToString("C", CultureInfo.GetCultureInfo("en-US")), 
				fsales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
				total += dsales + esales + fsales;
				WriteLine("Total sales were	{0}", 
				total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
				if(dsales > esales && dsales > fsales){
					WriteLine("Danielle sold the most");
				}
				if(esales > dsales && esales > fsales){
					WriteLine("Edward sold the most");
				}
				if(fsales > dsales && fsales > esales){
					WriteLine("Francis sold the most");
				}
				if(dsales == esales || dsales == fsales || esales == fsales){
					WriteLine("There was a tie");
				}
				loop += 1;
				break;

				default:
				WriteLine("Sorry - Invalid salesperson");
				Write("Enter salesperson intital or Z to quit: ");
				break;

			}
		}
	}
}
