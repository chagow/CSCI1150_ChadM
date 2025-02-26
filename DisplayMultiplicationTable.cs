using System;
using static System.Console;
using System.Globalization;
class DisplayMultiplicationTable
{
	static void Main()
	{
		for (int a = 0; a <= 10; a++){
			for (int b = 0; b <= 10; b++){
				Write(a * b + "\t");
			}
			Write("\n");
		}
	}
}
