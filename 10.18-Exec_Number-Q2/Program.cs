using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18_Exec_Number_Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Number
			//Q2: 找出數值區間內的所有質數?

			//A2:
			//輸入兩個數值來設定範圍
			Console.WriteLine("請輸入兩個數字來求取兩值中的所有值數，請注意兩數字中不可包含負數: ");
			Console.Write("請輸入起始值: ");
			string input1 = Console.ReadLine();
			bool isIntOfInput1 = int.TryParse(input1, out int start);
			Console.Write("請輸入結束值: ");
			string input2 = Console.ReadLine();
			bool isInOfInput2 = int.TryParse(input2, out int end);

			//防呆
			if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
			{
				Console.WriteLine("您沒有完成輸入兩個數值。");
				return;
			}

			if (start < 0 || end < 0)
			{
				Console.WriteLine("兩數字已經包含到負數，請重新輸入。");
				return;
			}


			//列出兩個數字中間的質數
			Console.WriteLine($"在{start}和{end}之間的所有質數有: ");
			for (int i = start; i <= end; i++)
			{
				int isPrime = 0;

				for (int k = 2; k <= (int)Math.Sqrt(i); k++)
				{
					if (i % k == 0)
					{
						isPrime++;
						break;
					}
				}

				if (isPrime == 0 && i != 0 && i != 1)
					Console.WriteLine($"{i}");
			}
		}
	}
}
