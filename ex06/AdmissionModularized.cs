using System;
using static System.Console;
using System.Globalization;
class AdmissionModularized
{
	static void Main()
	{
		int user_score;
		double user_gpa;
		Write("Enter high school GPA: ");
		user_gpa = Convert.ToDouble(ReadLine());
		Write("Enter admission test score: ");
		user_score = Convert.ToInt32(ReadLine());
		string userResult = AcceptOrReject(user_gpa, user_score);
		WriteLine(userResult);
	}
	public static string AcceptOrReject(double user_gpa, int user_score)
	{
		string result = "";
		if (user_gpa >= 3.0 && user_score >= 60 || user_gpa < 3.0 && user_score >= 80){
			result = "Accept";
			return result;
		} else{
			result = "Reject";
			return result;
		}
	}
}
