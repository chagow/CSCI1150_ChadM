using System;
using static System.Console;
using System.Globalization;
using System.Data;
class GreenvilleRevenue
{
   static void Main()
   {
    double oldcon = 0, newcon = 0, oldcheck, newcheck;
    double loop = 0;
    Write("Enter number of contestants last year: ");
    oldcheck = GetContestantNumber();
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
    newcheck = GetContestantNumber();
    while(loop == 1){
        if(newcheck < 0 || newcheck > 30){
            Write("Invalid amount. Re-enter the amount of contestants this year: ");
            newcheck = Convert.ToDouble(ReadLine());
        } else{
            newcon = newcheck;
            loop += 1;
        }
    }
    DisplayRelationship(oldcon, newcon);

    int thisCon = Convert.ToInt32(newcon);
    string[,] talentNames = new string[thisCon,2];
    GetContestantData(talentNames);
    for(int i = 0; i < thisCon; ++i){
        Write(talentNames[i,0]+" ");
        for(int j = 0; j < 1; ++j){
            WriteLine(talentNames[i,1]);
        }
    }
    GetLists(talentNames);

   }
   public static double GetContestantNumber()
   {
      double check;
      check = Convert.ToDouble(ReadLine());
      return check;
   }
   public static void DisplayRelationship(double oldcon, double newcon)
   {
      const double fee = 25;
      double revenue = newcon * fee;
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
   public static string[,] GetContestantData(string[,] array)
   {
    int i = 0, j = 0;
    int rowLength = array.GetLength(0);

    for(i = 0; i < rowLength; ++i){
        Write("Name {0}: ", i+1);
        array[i,0] = ReadLine();
        for(j = 0; j < 1; ++j){
            Write("Talent (S/D/M/O): ");
            array[i,1] = ReadLine();
        }
    }
    return array;
   }
   public static void GetLists(string[,] array)
   {
    int loop = 0;
    int rowLength = array.GetLength(0);
    int SCount = 0, DCount = 0, MCount = 0, OCount = 0;
    int[,] index = new int [4,rowLength]; 

    while(loop == 0){
        for(int i = 0; i < rowLength; ++i){
            if(array[i,1] == "S"){
                index[0,i] = i;
                SCount += 1;
            }
            if(array[i,1] == "D"){
                index[1,i] = i;
                DCount += 1;
            }
            if(array[i,1] == "M"){
                index[2,i] = i;
                MCount += 1;
            }
            if(array[i,1] == "O"){
                index[3,i] = i;
                OCount += 1;
            }
        }
        loop = 1;
    }
    WriteLine("The types of talent are: \nSinging: {0} \nDancing: {1} \nMusical Instrument: {2} \nOther: {3}",
    SCount, DCount, MCount, OCount);
   }
}
