using System;
using System.Linq;

namespace ListOfPredicates
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, int> divisible = (int x, int y) => x % y;
			int n = int.Parse(Console.ReadLine());
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = 1; i <= n; i++)
			{
				int times = 0;
				for (int j = 0; j < input.Length; j++)
				{
					int number = input[j];
					if(divisible(i, number) == 0)
					{
						times++;
					}
				}
				if (times == input.Length) Console.Write(i + " ");
			}
		}
	}
}
