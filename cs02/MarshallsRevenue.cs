using System;
using static System.Console;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
class MarshallsRevenue
{
   static void Main()
   {
    int intmural = 0, extmural = 0;
    string indoor = "interior", outdoor = "exterior";
    int month = GetMonth();
    intmural = GetNumMurals(indoor);
    if (month == 1 || month == 2 || month == 12){
      extmural = 0;
    } else{
      extmural = GetNumMurals(outdoor);
    }
    int totalrev = ComputeRevenue(month, intmural, extmural);
    WriteLine("Total revenue expected is {0}", totalrev.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("");
    DataEntry(indoor, intmural);
    if(extmural != 0){
      DataEntry(outdoor, extmural);
    }
   }
   public static int GetMonth()
   {
      int month = 0, mloop = 0, dataCheck;
      string inputString;
      bool result;
      while(month == 0){
        Write("Enter the month: ");
        inputString = ReadLine();
        result = Int32.TryParse(inputString,out dataCheck);
        if(result){
            mloop = Convert.ToInt32(inputString);
            if(mloop <= 0 || mloop > 12){
                WriteLine("Invalid month, Try again. ");
            } else{
                month = mloop;
            } 
        } else{
            WriteLine("Invalid input, Try again. ");
        }
            
      }
      return month;
   }
   public static int GetNumMurals(string location)
   {
      string inputString;
      bool result;
      int mural = 0, loop = 0, dataCheck;
      while(mural == 0){
        Write("Enter number of {0} murals scheduled: ", location);
        inputString = ReadLine();
        result = Int32.TryParse(inputString, out dataCheck);
        if(result){
            loop = Convert.ToInt32(inputString);
            if(loop <= 0 || loop > 30){
                WriteLine("Invalid interior mural amount. Try again. ");
            } else{
                mural = loop;
            }
        } else{
            WriteLine("Invalid input, Try again. ");
        }
    }
    return mural;
   }
   public static int ComputeRevenue(int month, int numInterior, int numExterior)
   {
      int intrevenue, extrevenue, totalrev;
      int intcost = 500, extcost = 750;
      if (month == 1 || month == 2 || month == 12){
         numExterior = 0;
      }
      if (month == 4 || month == 5 || month == 9 || month == 10){
         extcost = 699;
      }
      if (month == 7 || month == 8){
         intcost = 450;
      }
      intrevenue = numInterior * intcost;
      extrevenue = numExterior * extcost;
      totalrev = intrevenue + extrevenue;
      bool fact = numInterior > numExterior;
      WriteLine("{0} interior murals are scheduled for a total of {1}", numInterior,
         intrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled for a total of {1}", numExterior, 
         extrevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("It is " +fact+ " that there are more interior murals scheduled than exterior ones.");
      return totalrev;
   }
   public static void DataEntry(string location, int mural)
   {
    string[] muralType = {"Landscape","Seascape","Abstract","Children's","Other"};
    int[] muralAmount = new int[5];
    int i = 0, dataCheck;
    string inputString;
    bool result;
    for(i = 0; mural > 0; i++){
        bool restart = true;
        int loop = 0;
        while(restart){
            Write("How many {0} {1} murals: ", location, muralType[i]);
            inputString = ReadLine();
            result = Int32.TryParse(inputString, out dataCheck);
            if(result){
                int Design = Convert.ToInt32(inputString);
                while(loop == 0){
                    if(Design > mural){
                        WriteLine("That's over the amount of murals!");
                        Write("How many {0} {1} murals: ", location, muralType[i]);
                        Design = Convert.ToInt32(ReadLine());
                    } else{
                        mural -= Design;
                        loop += 1;
                    }
                }
                if(mural >= 0){
                    muralAmount[i] = Design;
                } else{
                    if(mural % Design == 0){
                        muralAmount[i] = mural % Design;
                    }
                }
                restart = false;
            } else{
                WriteLine("Invalid input, Try again. ");
            }
        }
    }

    WriteLine("The {0} murals scheduled are: ", location);
    for(i = 0; i < muralAmount.Length; i++){
        WriteLine("{0,-15}{1,15}", muralType[i], muralAmount[i]);
    }
   }
}
