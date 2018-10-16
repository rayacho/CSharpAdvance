using System;
using System.Linq;

namespace ActionPoint
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine(message);
			var input = Console.ReadLine().Split(' ').ToList();
			foreach(var word in input)
			{
				print(word);
			}
		}
	}
}
