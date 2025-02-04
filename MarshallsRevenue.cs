using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      double intmural, extmural, intrevenue, extrevenue, totalrev;
      Write("Enter number of interior murals scheduled: ");
      intmural = Convert.ToDouble(ReadLine());
      Write("Enter number of exterior murals scheduled: ");
      extmural = Convert.ToDouble(ReadLine());
      const double intcost = 500, extcost = 750;
      intrevenue = intmural * intcost;
      extrevenue = extmural * extcost;
      totalrev = intrevenue + extrevenue;
      bool fact = intmural > extmural;
      WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", intmural, 
                intcost.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                intrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", extmural, 
                extcost.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                extrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total revenue expected is {0}", totalrev.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("It is " +fact+ " that there are more interior murals scheduled than exterior ones.");
   }
}
