using System;
using static System.Console;
using System.Globalization;
class Sum200
{
	static void Main()
	{
		int sum = 0;
		for (int i = 0; i <= 200; i++){
			sum += i;
			if(i == 100){
				WriteLine(sum);
			}
			if(i == 200){
				WriteLine(sum);
			}
		}
	}
}
