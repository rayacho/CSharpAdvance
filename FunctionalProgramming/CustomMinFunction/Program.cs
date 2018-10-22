using System;
using System.Linq;

namespace CustomMinFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();	
			int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

			Func<int[], int> comparison = n =>
			{
				int min = n[0];
				for (int i = 1; i < n.Length; i++)
				{
					if (min > n[i])
					{
						min = n[i];
					}
				}
				return min;
			};

			Console.WriteLine(comparison(numbers));
		}
	}
}
