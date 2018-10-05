using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader(@"D:\text.txt"))
            {
                using (var writeStream = new StreamWriter("linenumbers.txt"))
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
