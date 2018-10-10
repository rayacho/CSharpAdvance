using System;
using System.IO;

namespace Ex1
{
    class Ex1
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\Ex1\Ex1.cs"))
            {
                var lineNumber = 1;

                string line;

                while((line = Console.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNumber}: " + line);
                    lineNumber++;
                }
            }
            
        }
    }
}
