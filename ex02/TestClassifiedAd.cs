using System;
using static System.Console;
using System.Globalization;
using System.Net.Mail;
class TestClassifiedAd
{

	static void Main()
	{
		ClassifiedAd Ad1 = new ClassifiedAd();
        ClassifiedAd Ad2 = new ClassifiedAd();
        Ad1.Category = "Used Cars";
        Ad1.Words = 100;
        Ad2.Category = "Help Wanted";
        Ad2.Words = 60;
        WriteLine("The classified ad with {0} words in category {1} costs {2}",
            Ad1.Words, Ad1.Category, Ad1.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("The classified ad with {0} words in category {1} costs {2}",
            Ad2.Words, Ad2.Category, Ad2.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

	}
}
class ClassifiedAd 
{
    private int words;
    private double price;
    public string? Category {get; set;}
    public int Words 
    {
        get
        {
            return words;
        } 
        set
        {
            words = value;
            CalcPrice();
        }
    }
    public double Price 
    {
        get
        {
            return this.price;
        }
    }
    private void CalcPrice()
    {
        this.price = Words * 0.09;
    }
}
