using System;
using static System.Console;
using System.Globalization;
class WebAddress
{
	static void Main()
	{
		string user_web;
		Write("What website are you looking for: ");
		user_web = ReadLine();
		user_web = user_web.Replace(" ", "");
		WriteLine("www."+user_web+".com");
	}
}
