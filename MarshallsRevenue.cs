using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      double intmural, extmural, intrevenue, extrevenue, totalrev, month;
      Write("Enter the month: ");
      month = Convert.ToDouble(ReadLine());
      Write("Enter number of interior murals scheduled: ");
      intmural = Convert.ToDouble(ReadLine());
      Write("Enter number of exterior murals scheduled: ");
      extmural = Convert.ToDouble(ReadLine());
      double intcost = 500, extcost = 750;
      if (month == 1 || month == 2 || month == 12){
         extmural = 0;
      }
      if (month == 4 || month == 5 || month == 9 || month == 10){
         extcost = 699;
      }
      if (month == 7 || month == 8){
         intcost = 450;
      }
      intrevenue = intmural * intcost;
      extrevenue = extmural * extcost;
      totalrev = intrevenue + extrevenue;
      bool fact = intmural > extmural;
      WriteLine("{0} interior murals are scheduled for a total of {1}", intmural,
                intrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled for a total of {1}", extmural, 
                extrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total revenue expected is {0}", totalrev.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("It is " +fact+ " that there are more interior murals scheduled than exterior ones.");
   }
}
