using System;
using System.Collections.Generic;

namespace EvenTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<int, int> numbers = new Dictionary<int, int>();

			for(int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				if (!numbers.ContainsKey(number))
					numbers.Add(number, 1);
				else numbers[number]++;
			}

			foreach(var number in numbers)
			{
				int value = number.Value;
				int key = number.Key;
				if(value % 2 == 0)
					Console.WriteLine(key);
			}
		}
	}
}
