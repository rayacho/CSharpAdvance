using System;
using System.Linq;

namespace CustomMinFunction
{
	class Program
	{
		static int min = int.MinValue;
		static void Main(string[] args)
		{
			Func<int, int> comparison = n =>
			{
				if (n > min)
				{
					n = min;
					return min;
				}
				else return n;
			};

			string input = Console.ReadLine();	
			int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
			
			foreach(var number in numbers)
			{
				comparison(number);
			}

			Console.WriteLine(min);
		}
	}
}
