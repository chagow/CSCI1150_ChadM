/* Sorry for being late on a lot of things as of lately
I have to submit this unfinished since I don't got a clue on
How to fix the print output to show all pieces of data for a Contestant.
Due to the major increase to code's size too, it's a bit hard to navigate through issues.
If there is one thing I may look into changing, is turning the
'contestants' list into an array, since it may be easier.
Also, the override ToString() is unfinished, which is another matter that I will look into.
Once again, sorry for the inconvenience */
using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
    List<Contestant> contestants = new List<Contestant>();
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
    string[,] talentNames = new string[thisCon,3];
    GetContestantData(talentNames, contestants);
    for(int i = 0; i < thisCon; ++i){
        Write(talentNames[i,0]+" ");
        for(int j = 0; j < 1; ++j){
            WriteLine(talentNames[i,1]);
        }
    }
    GetLists(talentNames);
    DisplayTable(contestants);
   }

   public static double GetContestantNumber()
   {
      string check;
      double dataCheck = 0;
      bool result, loop = true;
      while(loop == true){
         check = ReadLine();
         result = double.TryParse(check, out dataCheck);
         if(result == true){
            dataCheck = Convert.ToDouble(check);
            loop = false;
         } else{
            Write("Invalid Input, Try again: ");
         }
      }
      return dataCheck;
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
   public static string[,] GetContestantData(string[,] array, List<Contestant> contestants)
   {
    const int adultAge = 17;
    const int teenAge = 12;
    int i = 0, j = 0;
    int rowLength = array.GetLength(0);
    string check;
    bool result, loop1 = true, loop2 = true;
    while(loop1){
        for(i = 0; i < rowLength; ++i){
            Contestant contestant = new Contestant();
            Write("Name of Contestant {0}: ", i+1);
            while(loop2){
                int dataCheck;
                check = ReadLine();
                result = int.TryParse(check, out dataCheck);
                if(result){
                    Write("Invalid Input, Try again: ");
                } else{
                    contestant.Name = check;
                    array[i,0] = check;
                    loop2 = false;
                }
            }
            for(j = 0; j < 1; ++j){
                bool loop3 = true;
                Write("What is their Talent? (S/D/M/O): ");
                while(loop2 == false){
                    char dataCheck;
                    check = ReadLine();
                    result = char.TryParse(check, out dataCheck);
                    if(result){
                        string talentFix = check;
                        contestant.TalentCode = talentFix;
                        array[i,1] = talentFix.ToUpper();
                        loop2 = true;
                        contestants.Add(contestant);
                    } else{
                        Write("Invalid Input, Try again: ");
                    }
                }
                while(loop3){
                    int intCheck;
                    Write("What is their age: ");
                    string ageCheck = ReadLine();
                    bool ageResult = int.TryParse(ageCheck, out intCheck);
                    if(ageResult){
                        intCheck = Convert.ToInt32(ageCheck);
                        if(intCheck > adultAge){
                            contestants[i] = new AdultContestant();
                        }
                        else if (intCheck > teenAge){
                            contestants[i] = new TeenContestant();
                        }
                        else{
                            contestants[i] = new ChildContestant();
                        }
                        loop3 = false;
                    }
                    else{
                        Write("Invalid Input, Try again: ");
                    }
                }
            }
        }
        loop1 = false;
    }
    return array;
   }
   public static void GetLists(string[,] array)
   {
    bool loop = false;
    int rowLength = array.GetLength(0);
    int SCount = 0, DCount = 0, MCount = 0, OCount = 0;

    while(loop == false){
        for(int i = 0; i < rowLength; ++i){
            if(array[i,1] == "S"){
                SCount += 1;
            }
            if(array[i,1] == "D"){
                DCount += 1;
            }
            if(array[i,1] == "M"){
                MCount += 1;
            }
            if(array[i,1] == "O"){
                OCount += 1;
            }
        }
        loop = true;
    }

    WriteLine("The amount of talent are: \nSinging: {0} \nDancing: {1} \nMusical Instrument: {2} \nOther: {3}",
    SCount, DCount, MCount, OCount);
    char dataCheck;
    string check = "";
    bool result;
    while(loop == true){
        Write("What would you like to view (S/D/M/O) or 'Z' to quit: ");
        check = ReadLine();
        result = char.TryParse(check, out dataCheck);
        if(result){
            string consInput = check;
            switch(consInput.ToUpper()){
                case "S":
                WriteLine("Singing: ");
                    for(int i = 0; i < rowLength; ++i){
                        for(int j = 0; j < 1; ++j){
                            if(array[i,1] == "S"){
                                WriteLine("{0} ", array[i,0]);
                            }
                        }
                    }
                    break;
                case "D":
                    WriteLine("Dancing: ");
                    for(int i = 0; i < rowLength; ++i){
                        for(int j = 0; j < 1; ++j){
                            if(array[i,1] == "D"){
                                WriteLine("{0} ", array[i,0]);
                            }
                        }
                    }
                    break;
                case "M":
                    WriteLine("Musical Instrument: ");
                    for(int i = 0; i < rowLength; ++i){
                        for(int j = 0; j < 1; ++j){
                            if(array[i,1] == "M"){
                                WriteLine("{0} ", array[i,0]);
                            }
                        }
                    }
                    break;
                case "O":
                WriteLine("Other: ");
                    for(int i = 0; i < rowLength; ++i){
                        for(int j = 0; j < 1; ++j){
                            if(array[i,1] == "O"){
                                WriteLine("{0} ", array[i,0]);
                            }
                        }
                    }
                    break;
                case "Z":
                    loop = false;
                    break;
                default:
                    WriteLine("{0} is an invalid code", consInput.ToUpper());
                    break;
            }  
        } else{
            WriteLine("Invalid Input, Try again ");
        }
    }
   }

   static void DisplayTable(List<Contestant> contestants)
   {
        WriteLine("\nContestants: ");
        WriteLine("{0, -15} {1, -15} {2, -15} {3, -15}", "Name:", "Talent Code:", "Talent Name:", "Fee:");
        WriteLine(new string('_', 75));
        foreach(var contestant in contestants){
            WriteLine("{0, -15} {1, -15} {2, -15} {3,-15}", contestant.Name, contestant.TalentCode, contestant.TalentDescription, contestant.Fee);
        }
   }
}
class Contestant
{
    public static string[] talentCodes = {"S","D","M","O"};
    public static string[] talentStrings = {"Singing","Dancing","Musical Instrument","Other"};
    private string name;
    private string talentCode;
    private string talent;
    private int fee;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string TalentCode
    {
        get
        {
            return talentCode;
        }
        set
        {
            if(Array.IndexOf(talentCodes, value.ToUpper()) != -1)
            {
                talentCode = value.ToUpper();
                talent = talentStrings[Array.IndexOf(talentCodes, talentCode)];
            } else
            {
                talentCode = "I";
                talent = "Invalid";
            }
        }
    }
    public string TalentDescription
    {
        get
        {
            return talent;
        }
    }
    public int Fee 
    {
        get{return fee;} 
        set{fee = value;}
    }

}
class ChildContestant : Contestant
{
    public int childFee = 15;
    public ChildContestant()
    {
        Fee = childFee;
    }
    public override string ToString()
    {
        return GetType().Name + ": \nName: " + Name + " Talent: " + TalentCode + " Fee: " + Fee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}

class TeenContestant : Contestant
{
    public int teenFee = 20;
    public TeenContestant()
    {
        Fee = teenFee;
    }
    public override string ToString()
    {
        return GetType().Name + ": \nName: " + Name + " Talent: " + TalentCode + " Fee: " + Fee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}

class AdultContestant : Contestant
{
    public int adultFee = 30;
    public AdultContestant()
    {
        Fee = adultFee;
    }
    public override string ToString()
    {
        return GetType().Name + ": \nName: " + Name + " Talent: " + TalentCode + " Fee: " + Fee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
