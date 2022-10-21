using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18_Exec_Number_Bonus
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Number
			//Q:(BONUS) 計算1到m之間奇數或偶數的和

			//A:方法一
			Console.Write("請輸入任意正整數: ");
			string input = Console.ReadLine();
			int value = Convert.ToInt32(input);

			//防呆
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入任何值");
				return;
			}

			//方法一: 用迴圈
			int evenSum = 0;
			int oddSum = 0;

			int count = 0;
			if (value % 2 == 0)
			{
				for (int i = 0; i <= value; i += 2)
				{
					evenSum += i;
					count++;
				}
				Console.WriteLine(evenSum);
			}
			else
			{
				for (int k = 1; k <= value; k += 2)
				{
					oddSum += k;
					count++;
				}
				Console.WriteLine(oddSum);
			}




			//第二種寫法: for-if nested
			/*
			for (int j = 0; j <= value; j++)
			{
				if (value % 2 == 0 && j % 2 == 0)
				{
					evenSum += j;
				}
				if (value % 2 != 0 && j % 2 != 0)
				{
					oddSum += j;
				}
			}

			if ( value % 2 == 0)
			{
				Console.WriteLine(evenSum);
				return;
			}
			Console.WriteLine(oddSum);
			*/
			Console.WriteLine();

			//方法二: 用奇數和公式
			Console.Write("請輸入任意正整數: ");
			input = Console.ReadLine();
			value = Convert.ToInt32(input);

			//防呆
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入任何值");
				return;
			}

			// S = (a1+an)(n-1)/2
			//when an is even, then first item == 2
			//when an is odd, then first item == 1
			if (value % 2 == 0)
			{
				int a1Even = 2;
				int numOfItems = (value - a1Even) / 2 + 1;
				int sumEven = (a1Even + value) * numOfItems / 2;
				Console.WriteLine(sumEven);
			}
			else
			{
				int a1Odd = 1;
				int numOfItems = (value - a1Odd) / 2 + 1;
				int sumOdd = (a1Odd + value) * numOfItems / 2;
				Console.WriteLine(sumOdd);
			}
		}
	}
}
