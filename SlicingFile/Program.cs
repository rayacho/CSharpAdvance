﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SlicingFile
{
	class Program
	{
		private const int bufferSize = 4096;

		static void Main(string[] args)
		{
			string sourceFile = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\sliceMe.mp4";
			string destination = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\SlicingFile\";
			int parts = 5;

			Slice(sourceFile, destination, parts);

			var files = new List<string>
			{
				"Part-0.mp4",
				"Part-1.mp4",
				"Part-2.mp4",
				"Part-3.mp4",
				"Part-4.mp4",
			};

			Assemble(files, destination);
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

					using (FileStream writer = new FileStream(currentPart, FileMode.Create))
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

		static void Assemble(List<string> files, string destinationDirectory)
		{
			string extension = files.First().Substring(files[0].LastIndexOf('.') + 1);

			if (destinationDirectory == string.Empty)
			{
				destinationDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\SlicingFile\";
			}

			if (!destinationDirectory.EndsWith("/"))
			{
				destinationDirectory += "/";
			}

			string assembledFile = $"{destinationDirectory}Assembled.{extension}";

			using (FileStream writer = new FileStream(assembledFile, FileMode.Create))
			{
				byte[] buffer = new byte[bufferSize];

				foreach (var file in files)
				{
					using (FileStream reader = new FileStream(file, FileMode.Open))
					{
						while (reader.Read(buffer, 0, bufferSize) == bufferSize)
						{
							writer.Write(buffer, 0, bufferSize);
						}
					}
				}			
			}
		}
	}
}

