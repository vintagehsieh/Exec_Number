using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18_Exec_Number_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Number
			//Q3: 有一個數值是四位數，左邊二位的數字相同，右邊二位的數字相同，
			//    這個四位數值，剛好也是某整數的平方，請問這四位數字為何?

			//A3:

			for (int i = 1; i < 10; i++) //千分位不會是零，所以可以從1開始
			{
				for (int k = 0; k < 10; k++)
				{
					int num = i * 1100 + k * 11;
					double sqrt = Math.Sqrt(num);

					if (sqrt == Math.Floor(sqrt))
					{
						Console.WriteLine(num);
					}
				}
			}
		}
	}
}
