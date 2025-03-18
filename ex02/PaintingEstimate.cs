using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
	public static void Calculate(int userL, int userW)
	{
		int perSQFoot = 6;
		int height = 9;
		int lhSQ = (userL * height * 2) * perSQFoot; 
		int whSq = (userW * height * 2) * perSQFoot;
		int totalPrice = lhSQ + whSq;
		WriteLine("Cost of job for {0} X {1} foot room is {2}", userL, userW, 
		totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
	static void Main()
	{
		Write("Enter length of the room in feet: ");
		int userL = Convert.ToInt32(ReadLine());
		Write("Enter width of room in feet: ");
		int userW = Convert.ToInt32(ReadLine());
		Calculate(userL, userW);
	}
}
