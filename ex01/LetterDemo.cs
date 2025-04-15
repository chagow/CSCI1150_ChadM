using System;
using static System.Console;
using System.Globalization;
class LetterDemo
{
	static void Main()
	{
		Write("Enter name of the receiver: ");
        string inputName = ReadLine();
        Write("Enter date of the letter was mailed:");
        string inputDate = ReadLine();
        WriteLine("Is the letter certified? (Y/N):");
        string certification = ReadLine();
        Letter letter;

        if(certification.ToUpper() == "Y"){
            letter = new CertifiedLetter{Name = inputName, Date = inputDate};
        } else{
            letter = new Letter{Name = inputName, Date = inputDate};
        }
        WriteLine(letter.ToString());
	}
}
class Letter()
{
    public string Name {get; set;}
    public string Date {get; set;}
    public override string ToString()
    {
        return GetType().Name + " is sent to " + Name + " on " + Date + ".";
    }
}
class CertifiedLetter : Letter
{
    public int TrackingNumber {get;}
    public CertifiedLetter()
    {
        Random rnd = new Random();
        TrackingNumber = rnd.Next(100, 500);
    }
    public override string ToString()
    {
        return base.ToString() + " The tracking number is: " + TrackingNumber + ".";
    }
}
