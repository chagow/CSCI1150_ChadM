using System;
using static System.Console;
using System.IO;
class FileComparison
{
   static void Main()
   {
      string fileName1 = "Quote.docx";
      string fileName2 = "Quote.txt";
      FileInfo fileInfo1 = new FileInfo(fileName1);
      int size1 = (int) fileInfo1.Length;
      FileInfo fileInfo2 = new FileInfo(fileName2);
      int size2 = (int) fileInfo2.Length;
      double ratio = (double) size2 / size1 * 100;
      WriteLine("The size of the Word file is {0}", size1);
      WriteLine("and the size of the Notepad file is {0}", size2);
      WriteLine("The Notepad file is {0}% of the size of the Word file", ratio.ToString("#.##"));
   }
}
