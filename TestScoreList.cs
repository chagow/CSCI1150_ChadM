using System;
using static System.Console;
using System.Globalization;
class TestScoreList
{
	static void Main()
	{
		double scoreInput, scoreSum = 0;
		double scoreAvg;
		double[] scoreList = new double[8];
		for(int i = 0; i < scoreList.Length; i++){
			Write("Enter your score: ");
			scoreInput = Convert.ToDouble(ReadLine());
			scoreSum += scoreInput;
			scoreList[i] = scoreInput;
		}
		
		WriteLine("");
		scoreAvg = scoreSum / scoreList.Length;

		for(int i = 0; i < scoreList.Length; i++){
			WriteLine("Test # "+(i)+":	"+scoreList[i]+" From average: "+(scoreList[i] - scoreAvg));
		}
	}
}
