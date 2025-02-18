using System;
using static System.Console;
using System.Globalization;
class CheckMonth2
{
	static void Main()
	{
		int user_month, user_day;
		Write("Enter your birth month number: ");
		user_month = Convert.ToInt32(ReadLine());
		Write("Enter your birth day number: ");
		user_day = Convert.ToInt32(ReadLine());
		switch (user_month){
			case 1:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 2:
			if (user_day <= 29 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 3:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 4:
			if (user_day <= 30 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 5:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 6:
			if (user_day <= 30 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 7:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 8:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 9:
			if (user_day <= 30 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 10:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 11:
			if (user_day <= 30 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			case 12:
			if (user_day <= 31 && user_day >= 1){
				WriteLine(user_month+"/"+user_day+" is a valid birthday");
				break;
			} else{
				WriteLine("Invalid date");
				break;}
			default:
			WriteLine("Invalid date");
			break;
		}
	}
}
