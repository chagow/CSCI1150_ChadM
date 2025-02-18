using System;
using static System.Console;
using System.Globalization;
class Admission
{
	static void Main()
	{
		int user_score;
		double user_gpa;
		Write("Enter high school GPA: ");
		user_gpa = Convert.ToDouble(ReadLine());
		Write("Enter admission test score: ");
		user_score = Convert.ToInt32(ReadLine());
		if (user_gpa >= 3.0 && user_score >= 60 || user_gpa < 3.0 && user_score >= 80){
			WriteLine("Accept");
		} else{
			WriteLine("Reject");
		}
	}
}
