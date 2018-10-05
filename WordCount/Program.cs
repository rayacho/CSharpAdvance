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
                using (var readWords = new StreamReader(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\words.txt"))
                {
                    using (var writeStream = new StreamWriter(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\WordCount\result.txt"))
                    {
                        int times1 = 0, times2 = 0, times3 = 0;
                        string firstWord = readWords.ReadLine();
                        string secondWord = readWords.ReadLine();
                        string thirdWord = readWords.ReadLine();
                        string line = readStream.ReadLine();
                        while (line != null)
                        {
                            string[] input = line.Split();
                            int length = input.Length;
                            for(int i = 0; i < length; i++)
                            {
                                if (firstWord == input[i]) times1++;
                                if (secondWord == input[i]) times2++;
                                if (thirdWord == input[i]) times3++;
                            }
                            line = readStream.ReadLine();
                        }
                        writeStream.WriteLine(firstWord + ' ' + times1);
                        writeStream.WriteLine(secondWord + ' ' + times2);
                        writeStream.WriteLine(thirdWord + ' ' + times3);
                    }
                }
            }
        }
    }
}
