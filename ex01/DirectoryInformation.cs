using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
   static void Main()
   {
      string userInput = "";
      bool loop = true;
      WriteLine("Enter a directory");
      while(loop){
         userInput = ReadLine();
         if(userInput.ToLower() == "end"){
            loop = false;
         }
         else{
            if(Directory.Exists(userInput)){
               WriteLine(userInput + " contains the following files");
               string[] showFiles = Directory.GetFiles(userInput);
               for(int i = 0; i < showFiles.Length; ++i){
                  WriteLine("   {0}", showFiles[i]);
               }
               WriteLine("Enter another directory or type end to quit");
            }
            else{
               WriteLine("Directory " + userInput + " does not exist");
               WriteLine("Enter another directory or type end to quit");
            }            
         }
      }
   }
}
