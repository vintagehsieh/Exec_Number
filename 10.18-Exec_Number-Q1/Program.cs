using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18_Exec_Number_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Number
			//Q1: 判斷某數值是不是質數?

			//A1: sieve of Eratosthenes
			//把欲判斷的數值開根號\sqrt{N}後，並從2開始，到不超過根號N的數，逐一測試
			Console.Write("請輸入任何一大於二且非零的整數值: ");
			string input = Console.ReadLine();
			int value = Convert.ToInt32(input);

			//輸入值的開根號
			double sqrtValue = Math.Sqrt(value);

			//取開根號的整數值
			int intPartOfValue = (int)sqrtValue;

			//防呆
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入任何數值");
				return;
			}

			//0和1不滿足質數定義
			if (value == 0 || value == 1)
			{
				Console.WriteLine($"{value} 不是質數");
				return;
			}

			//負數也不滿足質數定義
			if (value < 0)
			{
				Console.WriteLine("請輸入大於二且非零的正整數。");
				return;
			}

			for (int i = 2; i <= intPartOfValue; i++)
			{
				if (value % i == 0)
				{
					Console.WriteLine($"{value} 不是質數。");
					return;
				}
			}
			Console.WriteLine($"{value} 是質數。");
		}
	}
}
