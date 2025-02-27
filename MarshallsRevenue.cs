using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      double intmural = 0, extmural = 0, intrevenue, extrevenue, totalrev, month = 0;
      double mloop = 0, eloop = 0, iloop = 0;
      while(month == 0){
         Write("Enter the month: ");
         mloop = Convert.ToDouble(ReadLine());
         if(mloop <= 0 || mloop > 12){
            Write("Invalid month. Try again. ");
         } else{
            month = mloop;
         }
      }
      while(intmural == 0){
         Write("Enter number of interior murals scheduled: ");
         iloop = Convert.ToDouble(ReadLine());
         if(iloop <= 0 || iloop > 30){
            Write("Invalid interior mural amount. Try again. ");
         } else{
            intmural = iloop;
         }
      }
      while(extmural == 0){
         Write("Enter number of exterior murals scheduled: ");
         eloop = Convert.ToDouble(ReadLine());
         if(eloop <= 0 || eloop > 30){
            Write("Invalid exterior mural amount. Try again. ");
         } else{
            extmural = eloop;
         }
      }
      
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
