using System;
using static System.Console;
using System.Globalization;
class FlexibleArrayMethod
{
	static void Main()
	{
		int[] array1 = {1, 2, 3};
		int[] array2 = {4, 5, 6};
		int[] array3 = {7, 8, 9};
		DisplayAndSum(array1);
		DisplayAndSum(array2);
		DisplayAndSum(array3);
	}
	public static void DisplayAndSum(int[] array)
	{
		int sum = 0;
		for(int i = 0; i < array.Length; i++){
			sum += array[i];
			Write(array[i]+" ");
		}
		WriteLine("The sum of the array is: "+sum);
	}
}
