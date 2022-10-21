using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._18_Exec_Number_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Number
			//Q4: 百元買百雞，想用一百元買剛好一百隻雞，公雞5元，母雞3元，小雞三隻1元

			//A4: 
			// x = cock, 最多20隻
			// y = hen, 最多33隻
			// z = chicken

			int count = 0;

			for (int cock = 0; cock < 20; cock++)
			{
				for (int hen = 0; hen < (100 - 5 * cock) / 3; hen++)
				{
					count++;

					int chicken = 100 - cock - hen;
					double pricee = 5 * cock + 3 * hen + (double)chicken / 3.0;

					if (pricee == 100)
					{
						Console.WriteLine($"可用100元買到公雞{cock}隻、母雞{hen}隻、小雞{chicken}隻。");
					}

				}

			}
			Console.WriteLine($"此for回圈共跑{count}圈");
		}
	}
}
