using System;
using static System.Console;
using System.Globalization;
class ArrayDemo
{
	enum Menu
	{
		IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
	}
	static void Main()
	{
		int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
		
		WriteLine("How do you want to view the list from 1-10? ");
		int user_input = 0;
		
		while(user_input != 4){
			WriteLine("1. First to last\n2. Last to first\n3. View a number\n4. Quit");
			user_input = Convert.ToInt32(ReadLine());
			switch(user_input){
				case 1:
				for(int i = 0; i < nums.Length; i++){
					Write(nums[i]+" ");
				}
				WriteLine("");
				break;

				case 2:
				Array.Reverse(nums);
				for(int i = 0; i < nums.Length; i++){
					Write(nums[i]+" ");
				}
				WriteLine("");
				break;

				case 3:
				for(int i = 0; i < nums.Length; i++){
					Write(nums[i]+" ");
				}
				Write("Which number would you like to view? (input the index): ");
				int viewInput = Convert.ToInt32(ReadLine());
				WriteLine(nums[viewInput-1]);
				break;

				case 4:
				WriteLine("quit");
				break;

				default:
				WriteLine("Invalid choice, input again");
				WriteLine("");
				break;

			}
		}
	}
}
