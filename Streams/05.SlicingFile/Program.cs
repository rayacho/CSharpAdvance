using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SlicingFile
{
	class Program
	{
		static void Main(string[] args)
		{
			int parts = 5;
			string sourceFilePath = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\sliceMe.mp4";
			string destinationDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\05.SlicingFile\";

			Slice(sourceFilePath, destinationDirectory, parts);

			List<string> files = new List<string>();

			for (int i = 0; i < parts; i++)
			{
				files.Add($"{destinationDirectory}/Part-{i}.mp4");
			}

			string assembledDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\05.SlicingFile\";

			Assemble(files, assembledDirectory);
		}

		private static void Assemble(List<string> files, string destinationDirectory)
		{
			using (FileStream destination = new FileStream($"{destinationDirectory}/Assembled.mp4", FileMode.Create))
			{
				foreach (string file in files)
				{
					using (FileStream partStream = new FileStream(file, FileMode.Open))
					{
						byte[] buffer = new byte[4096];
						int readBytes;

						while ((readBytes = partStream.Read(buffer, 0, buffer.Length)) != 0)
						{
							destination.Write(buffer, 0, readBytes);
						}
					}
				}
			}
		}

		static void Slice(string sourceFile, string destinationDirectory, int parts)
		{
			using (FileStream source = new FileStream(sourceFile, FileMode.Open))
			{
				double partSize = source.Length / parts;

				for (int i = 0; i < parts; i++)
				{
					using (FileStream destination = new FileStream($"{destinationDirectory}/Part-{i}.mp4", FileMode.Create))
					{
						byte[] buffer = new byte[4096];
						int readBytes;

						while (destination.Length < partSize && (readBytes = source.Read(buffer, 0, buffer.Length)) != 0)
						{
							destination.Write(buffer, 0, readBytes);
						}
					}
				}
			}
		}
	}
}