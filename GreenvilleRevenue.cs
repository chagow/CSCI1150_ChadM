using System;
using static System.Console;
using System.Globalization;
using System.Data;
class GreenvilleRevenue
{
   static void Main()
   {
    double oldcon, newcon, revenue, oldcheck, newcheck;
    double loop = 0;
    int i = 0;
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

    int thisCon = Convert.ToInt32(newcon);
    string[] talentNames = new string[thisCon];
    string[] singAmount = new string[thisCon];
    string[] danceAmount = new string[thisCon];
    string[] musicAmount = new string[thisCon];
    string[] otherAmount = new string[thisCon];

    while(i < talentNames.Length){
        WriteLine("");
        Write("Please enter contestant name: ");
        string nameInput = ReadLine();
        int talentCheck = 0;
        while(talentCheck == 0){
            Write("\nWhat is their talent? (S/D/M/O Z to not include): ");
            string consInput = ReadLine();
            switch(consInput.ToUpper()){
                case "S":
                    singAmount[i] = nameInput;
                    WriteLine("Contestants talented with Singing: ");
                    for(int j = 0; j < singAmount.Length; j++){
                        if(singAmount[j] == null){
                        } else{
                            WriteLine("{0} ",singAmount[j]);
                        }
                    }
                    talentCheck = 1;
                    break;
                case "D":
                    danceAmount[i] = nameInput;
                    WriteLine("Contestants talented with Dancing: ");
                    for(int j = 0; j < danceAmount.Length; j++){
                        if(danceAmount[j] == null){
                        } else{
                            WriteLine("{0} ",danceAmount[j]);
                        }
                    }
                    talentCheck = 1;
                    break;
                case "M":
                    musicAmount[i] = nameInput;
                    WriteLine("Contestants talented with Musical Instruments: ");
                    for(int j = 0; j < musicAmount.Length; j++){
                        if(musicAmount[j] == null){
                        } else{
                            WriteLine("{0} ",musicAmount[j]);
                        }
                    }
                    talentCheck = 1;
                    break;
                case "O":
                    otherAmount[i] = nameInput;
                    WriteLine("Contestants talented with Other skills: ");
                    for(int j = 0; j < otherAmount.Length; j++){
                        if(otherAmount[j] == null){
                        } else{
                            WriteLine("{0} ",otherAmount[j]);
                        }
                    }
                    talentCheck = 1;
                    break;
                case "Z":
                    talentCheck = 1;
                    break;
                default:
                    WriteLine("{0} is an invalid code");
                    break;
            }
        }
        i++;
    }
   }
}
