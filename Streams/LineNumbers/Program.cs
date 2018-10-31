using System;
using System.IO;

namespace LineNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader readStream = new StreamReader(@"D:\text.txt"))
			{
				using (StreamWriter writeStream = new StreamWriter(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\LineNumbers\linenumbers.txt"))
				{
					int lineNumber = 1;
					string line;

					while ((line = readStream.ReadLine()) != null)
					{
						writeStream.WriteLine($"Line {lineNumber}: " + line);
						lineNumber++;
					}
				}
			}
		}
	}
}
