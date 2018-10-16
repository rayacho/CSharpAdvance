using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace ZippingSlicedFile
{
	class Program
	{
		static void Main(string[] args)
		{
			int parts = 5;
			string sourceFilePath = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\sliceMe.mp4";
			string destinationDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\ZippingSlicedFile\";

			Slice(sourceFilePath, destinationDirectory, parts);

			List<string> files = new List<string>();

			for (int i = 0; i < parts; i++)
			{
				files.Add($"{destinationDirectory}/Part-{i}.gz");
			}

			string assembledDirectory = @"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\ZippingSlicedFile\";

			Assemble(files, assembledDirectory);	
		}

		private static void Assemble(List<string> files, string destinationDirectory)
		{
			using (FileStream destination = new FileStream($"{destinationDirectory}/Assembled.mp4", FileMode.Create))
			{
				foreach (var file in files)
				{
					using (FileStream partStream = new FileStream(file, FileMode.Open))
					{
						using (GZipStream decompressingStream = new GZipStream(partStream, CompressionMode.Decompress, false))
						{
							byte[] buffer = new byte[4096];
							int readBytes;

							while ((readBytes = decompressingStream.Read(buffer, 0, buffer.Length)) != 0)
							{
								destination.Write(buffer, 0, readBytes);
							}
						}
					}
				}
			}
		}

		static void Slice(string sourceFile, string destinationDirectory, int parts)
		{
			using (FileStream source = new FileStream(sourceFile, FileMode.Open))
			{
				long partSize = (long)Math.Ceiling((double)source.Length / parts);

				for (int i = 0; i < parts; i++)
				{
					using (FileStream destination = new FileStream($"{destinationDirectory}/Part-{i}.gz", FileMode.Create))
					{
						using (GZipStream compressionStream = new GZipStream(destination, CompressionMode.Compress, false))
						{
							byte[] buffer = new byte[4096];
							int readBytes;
							long position = 0;

							while (position < partSize && (readBytes = source.Read(buffer, 0, buffer.Length)) > 0)
							{
								compressionStream.Write(buffer, 0, readBytes);
								position += readBytes;
							}
						}
					}
				}
			}
		}
	}
}