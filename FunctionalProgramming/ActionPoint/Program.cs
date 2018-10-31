using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPoint
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine(message);
			List<string> input = Console.ReadLine().Split(' ').ToList();
			foreach(string word in input)
			{
				print(word);
			}
		}
	}
}
