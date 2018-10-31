using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isOdd = x => x % 2 != 0;
			Predicate<int> isEven = x => x % 2 == 0;

			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> evenNumbers = new List<int>();
			List<int> oddNumbers = new List<int>();

			foreach (int number in input)
			{
				if (isOdd.Invoke(number))
				{
					oddNumbers.Add(number);
				}

				else if(isEven.Invoke(number))
				{
					evenNumbers.Add(number);
				}
			}

			oddNumbers.Sort();
			evenNumbers.Sort();

			foreach(int even in evenNumbers)
			{
				Console.Write(even + " ");
			}

			foreach(int odd in oddNumbers)
			{
				Console.Write(odd + " ");
			}
		}
	}
}
