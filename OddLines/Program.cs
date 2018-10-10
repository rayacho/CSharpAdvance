using System;
using System.IO;

namespace OddLines
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var stream = new StreamReader(@"D:\text.txt"))
			{
				var lineNumber = 0;

				string line;

				while ((line = Console.ReadLine()) != null)
				{
					lineNumber++;
					if (lineNumber % 2 == 0)
					{
						Console.WriteLine(line);
					}
				}
			}
		}
	}
}
