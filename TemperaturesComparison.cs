using System;
using static System.Console;
using System.Globalization;
class TemperaturesComparison
{
	static void Main()
	{
		double tempInput, tempSum = 0;
		double tempAvg;
		int warmPattern = 0, coldPattern = 0;
		double[] tempList = new double[5];
		for(int i = 0; i < tempList.Length; i++){
			int loop = 0;
			while(loop == 0){
				Write("Insert a temperature in Fahrenheit (From -30 to 130): ");
				tempInput = Convert.ToDouble(ReadLine());
				if(tempInput >= -30 && tempInput <= 130){
					tempSum += tempInput;
					tempList[i] = tempInput;
					loop = 1;
				} else
					WriteLine("Invalid temperature, try again. ");
			}
		}
		tempAvg = tempSum / tempList.Length;

		for(int i = 0; i < (tempList.Length - 1); i++){
			if(tempList[i+1] < tempList[i]){
				warmPattern = 0;
				break;
			}else{
				warmPattern = 1;
			}
		}
		for(int i = 0; i < (tempList.Length - 1); i++){
			if(tempList[i] > tempList[i+1]){
				coldPattern = 1;
			} else{
				coldPattern = 0;
				break;
			}
		}
		if(warmPattern == 1){
			Write("Getting warmer: ");
		}
		if(coldPattern == 1){
			Write("Getting cooler: ");
		}
		if(warmPattern == 0 && coldPattern == 0){
			Write("It's a mixed bag: ");
		}
		for(int i = 0; i < tempList.Length; i++){
			Write(tempList[i]+" ");
		}
		WriteLine("");
		WriteLine("Average: "+tempAvg);
	}
}
