using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine($"Sir {message}");
			List<string> input = Console.ReadLine().Split(' ').ToList();
			foreach (var word in input)
			{
				print(word);
			}
		}
	}
}

