using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
	static void DisplayContactInfo()
	{
		WriteLine("Sea Company");
		WriteLine("Phone: 555-4334	Cell: 555-04044");
		WriteLine("Email: seacompany@seasalt.com");
		WriteLine("On the Web at www.seacompany.com");
		WriteLine("____________________________");
		WriteLine("");
	}

	static void Main()
	{
		WriteLine(" From");
		DisplayContactInfo();
		WriteLine("Dear Client, ");
		WriteLine("We want to provide you good service.");
		WriteLine("Feel free to contact us at any time.");
		DisplayContactInfo();
		WriteLine("Looking forward to a long relationship. ");
		DisplayContactInfo();
	}
}
