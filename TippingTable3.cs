using System;
using static System.Console;
using System.Globalization;
class TippingTable3
{
	static void Main()
	{
		double [] billings = new double[2];
		double [] tippercent = new double[2];
		for(int i = 0; i < 2; i++){
			Write("Insert restaurant bill {0} : ", i+1);
			billings[i] = Convert.ToDouble(ReadLine());
		}
		for(int i = 0; i < 2; i++){
			Write("Insert tipping percentage {0} : ", i+1);
			tippercent[i] = Convert.ToDouble(ReadLine());
		}
		foreach(double bill in billings){
			foreach(double percent in tippercent){
				double tipamount = bill * percent;
				Write("{0} ", tipamount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
			}
		}
	}
}
