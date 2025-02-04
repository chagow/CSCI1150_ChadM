using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
      double oldcon, newcon, revenue;
      Write("Enter number of contestants last year: ");
      oldcon = Convert.ToDouble(ReadLine());
      Write("Enter number of contestants this year: ");
      newcon = Convert.ToDouble(ReadLine());
      const double fee = 25;
      revenue = newcon * fee;
      bool fact = newcon > oldcon;
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", oldcon, newcon);
      WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("It is " +fact+ " that this year's competition is bigger than last year's");
   }
}
