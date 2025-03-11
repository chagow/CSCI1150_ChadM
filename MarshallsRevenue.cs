using System;
using static System.Console;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
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


// Hello!
// Sorry for the unfinished and late work.
// I submitted this assignment about half done.
// I'll admit, I couldn't figure out how to implement name input for each mural type.
// So if you have the time, I would like your thoughts or some advice on what I could've done.
// Thank you in advance!
    WriteLine("");
    string[] muralType = {"Landscape", "Seascape","Abstract","Children's","Other"};
    int intAmount = Convert.ToInt32(intmural);
    int extAmount = Convert.ToInt32(extmural);
    int[] intType = new int[5];
    int[] extType = new int[5];
    int i = 0;

    for(i = 0; intAmount > 0; i++){
        int idloop = 0;
        Write("How many interior {0} murals: ", muralType[i]);
        int intDesign = Convert.ToInt32(ReadLine());
        while(idloop == 0){
            if(intDesign > intAmount){
                WriteLine("That's over the amount of murals!");
                Write("How many interior {0} murals: ", muralType[i]);
                intDesign = Convert.ToInt32(ReadLine());
            } else{
                intAmount -= Convert.ToInt32(intDesign);
                idloop += 1;
            }
        }
        if(intAmount >= 0){
            intType[i] = intDesign;
        } else{
            if(intAmount % intDesign == 0){
                intType[i] = intAmount % intDesign;
            }
        }
    }

    WriteLine("The interior murals scheduled are: ");
    for(i = 0; i < intType.Length; i++){
        WriteLine("{0,-15}{1,15}", muralType[i], intType[i]);
    }

    for(i = 0; extAmount > 0; i++){
        int edloop = 0;
        Write("How many exterior {0} murals: ", muralType[i]);
        int extDesign = Convert.ToInt32(ReadLine());
        while(edloop == 0){
            if(extDesign > extAmount){
                WriteLine("That's over the amount of murals!");
                Write("How many exterior {0} murals: ", muralType[i]);
                extDesign = Convert.ToInt32(ReadLine());
            } else{
                extAmount -= Convert.ToInt32(extDesign);
                edloop += 1;
            }
        }
        if(extAmount >= 0){
            extType[i] = extDesign;
        } else{
            if(extAmount % extDesign == 0){
                extType[i] = extAmount % extDesign;
            }
        }
    }
    WriteLine("The exterior murals scheduled are: ");
    for(i = 0; i < extType.Length; i++){
        WriteLine("{0,-15}{1,15}", muralType[i], extType[i]);
    }
   }
}
