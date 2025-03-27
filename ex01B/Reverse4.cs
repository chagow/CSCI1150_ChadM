using System;
using static System.Console;
using System.Globalization;
class Reverse4
{
	
	static void Main()
	{
		int firstInt = 23, secondInt = 45, thirdInt = 55, lastInt = 67;
		WriteLine("{0} {1} {2} {3}", firstInt, secondInt, thirdInt, lastInt);
		Reverse(ref firstInt, ref secondInt, ref thirdInt, ref lastInt);
		WriteLine("{0} {1} {2} {3}", firstInt, secondInt, thirdInt, lastInt);
	}
	public static void Reverse(ref int intA, ref int intB, ref int intC, ref int intD)
	{
		int temp1 = intA;
		int temp2 = intB;
		intA = intD;
		intD = temp1;
		intB = intC;
		intC = temp2;
	}
}
