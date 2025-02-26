using System;
using static System.Console;
using System.Globalization;
class Perfect
{
	static void Main()
	{
		for(int i = 1; i <= 10000; i++){
			int sum = 0;
			int a = 1;
			while(a < i){
				if(i % a == 0){
					sum += a;
				}
				a++;
			}
			if(sum == i){
				Write(i+" ");
			}
		}
	}
}
