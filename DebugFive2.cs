// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must reenter the number
// The program displays the correct price
using System;
using static System.Console;
using System.Globalization;
class DebugFive2
{
   static void Main()
   {
      const double ITEM209 = 209;
      const double ITEM312 = 312;
      const double ITEM414 = 414;
      const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
      double price;
      double stockNum;
      Write("Please enter the stock number of the item you want ");
      stockNum = Convert.ToDouble(ReadLine());
      while(stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
      {
         WriteLine("Invalid stock number. Please enter again. ");
         stockNum = Convert.ToDouble(ReadLine());
      }
      if(stockNum == ITEM209)
         price = PRICE209;
      else
         if(stockNum == ITEM312)
            price = PRICE312;
         else
            price = PRICE414;
      WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}
