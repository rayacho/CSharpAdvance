using System;

namespace PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<string, int, int> equal = (string name, int n) => name.Length - n;

			int length = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine().Split(' ');
			foreach (string name in names)
			{
				if (equal(name, length) <= 0)
					Console.WriteLine(name);
			}
		}
	}
}
