using System;
using static System.Console;
using System.Globalization;
class TypingGrades
{
	static void Main()
	{
		double[] wordsTyped = {0, 16, 31, 51, 76};
	        string[] grade = {"F", "D", "C", "B", "A" };
	        int gradeCheck = wordsTyped.Length - 1;
	        double studentTyped = 0;
	        string finalGrade;
	        Write("How many words did you type: ");
	        studentTyped = Convert.ToDouble(ReadLine());
	        while(gradeCheck >= 0 && studentTyped < wordsTyped[gradeCheck]){
	            --gradeCheck;
	        }
	        finalGrade = grade[gradeCheck];
	        WriteLine("Typing "+studentTyped+" per minute: Grade: "+finalGrade);
	}
}
