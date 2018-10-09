using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
	class Program
	{
		private const int bufferSize = 4096;

		static void Main(string[] args)
		{
			string sourceFile = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\sliceMe.mp4";
			string destination = "";
			int parts = 5;

			Slice(sourceFile, destination, parts);
		}

		static void Slice(string sourceFile, string destinationDirectory, int parts)
		{
			using (FileStream reader = new FileStream(sourceFile, FileMode.Open))

			{
				string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
				long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);
				long currentPieceSize = 0;

				for (int i = 0; i < parts; i++)
				{

					if (destinationDirectory == string.Empty)
					{
						destinationDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\SlicingFile\";
					}
					string currentPart = destinationDirectory + $"Part-{i}.{extension}";
					using (FileStream writer = new FileStream(currentPart,FileMode.Create))
					{
						byte[] buffer = new byte[bufferSize];
						while (reader.Read(buffer, 0, bufferSize) == bufferSize)
						{
							writer.Write(buffer, 0, bufferSize);
							currentPieceSize += bufferSize;
							if (currentPieceSize >= pieceSize)
							{
								break;
							}
						}
					}
				}
				
			}
		
		}
		static void Zip(List<string> files, string destinationDirectory)
		{

		}
	}

}

