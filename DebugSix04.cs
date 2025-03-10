/* 
   The program prompts a user for up to 20 values and averages them
*/ 
using System;
using static System.Console;
using System.Globalization;
class DebugSix04
{
   public static void Main()
   {
      const int QUIT = 999;
      int[] numbers = new int[20];
      int x = 0;
      int num = 0;
      double average;
      double total = 0;
      string inString;
      
      while((x < numbers.Length) || num == QUIT)
      {
        Write("Please enter a number or " +
            QUIT + " to quit... ");
        inString = ReadLine();
        num = Convert.ToInt32(inString);
 	     numbers[x] = num;
        total += numbers[x];
        ++x;
      }
      WriteLine("The numbers are:");
      for(int y = 0; y < (x); ++y)
          Console.Write("{0} ", numbers[y]);
      average = total / numbers.Length;
      WriteLine();
      WriteLine("The average is {0}", average);
  }
}
