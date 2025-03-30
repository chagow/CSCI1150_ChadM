using System;
using static System.Console;
using System.Globalization;
class Reverse3
{
	
	static void Main()
	{
		int firstInt = 23, middleInt = 45, lastInt = 67;
		WriteLine("{0} {1} {2}", firstInt, middleInt, lastInt);
		Reverse(ref firstInt, ref middleInt, ref lastInt);
		WriteLine("{0} {1} {2}", firstInt, middleInt, lastInt);
	}
	public static void Reverse(ref int intA, ref int intB, ref int intC)
	{
		int temp = intA;
		intA = intC;
		intC = temp;
	}
}
