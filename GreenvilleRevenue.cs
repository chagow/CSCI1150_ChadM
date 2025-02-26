using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
      double oldcon, newcon, revenue, oldcheck, newcheck;
      double loop = 0;
      oldcon = 0;
      newcon = 0;
      Write("Enter number of contestants last year: ");
      oldcheck = Convert.ToDouble(ReadLine());
      while(loop == 0){
         if(oldcheck < 0 || oldcheck > 30){
            Write("Invalid amount. Re-enter the amount of contestants last year: ");
            oldcheck = Convert.ToDouble(ReadLine());
         } else{
            oldcon = oldcheck;
            loop += 1;
         }
      }
      Write("Enter number of contestants this year: ");
      newcheck = Convert.ToDouble(ReadLine());
      while(loop == 1){
         if(newcheck < 0 || newcheck > 30){
            Write("Invalid amount. Re-enter the amount of contestants this year: ");
            newcheck = Convert.ToDouble(ReadLine());
         } else{
            newcon = newcheck;
            loop += 1;
         }
   }
      const double fee = 25;
      revenue = newcon * fee;
      bool fact = newcon > oldcon;
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", oldcon, newcon);
      WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("It is " +fact+ " that this year's competition is bigger than last year's");
      if (newcon >= oldcon * 2){
         WriteLine("The competition is more than twice as big this year!");
      }
      if (newcon > oldcon && newcon < oldcon * 2){
         WriteLine("The competition is bigger than ever!");
      }
      if(newcon < oldcon){
         WriteLine("A tighter race this year! Come out and cast your vote!");
      }
   }
}
