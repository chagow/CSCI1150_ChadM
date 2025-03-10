using System;
using static System.Console;
using System.Globalization;
class GuessAWord
{
	static void Main()
	{
        	string [] words = {"APPLE", "PEAR", "CHERRY", "BANANA",
            		"LEMON", "RASPBERRY", "ORANGE", "PINEAPPLE"};
		Random ranNumberGenerator = new Random();
		int randomNumber, loop = 0;
        	string user_guess = "";
		randomNumber = ranNumberGenerator.Next(0, 7);
	        string wordChosen = words[randomNumber];
	
	        for(int i = 0; i < wordChosen.Length; i++){
	            Write("*");
	        }
	        WriteLine("");
	        Write("Guess the fruit: ");
	        while(loop == 0){
	            user_guess = ReadLine();
	            foreach(char letter in wordChosen){
	                string letterCheck = letter.ToString();
	                letterCheck.ToUpper();
	                if(user_guess.ToUpper().Contains(letterCheck)){
	                    Write(letter);
	                } else{
	                    Write("*");
	                }
	            }
	            WriteLine("");
	            if(user_guess.ToUpper() == wordChosen){
	                WriteLine("Congratulations! ");
	                loop = 1;
	            } else{
	        	Write("\nGuess again: ");
	                }
		}
	}
}
