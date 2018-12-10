using System;
using System.IO;

namespace CopyBinaryFile
{
	class Program
	{
		static void Main(string[] args)
		{
			using (FileStream sourceFile = new FileStream(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\copyMe.png", FileMode.Open))
			{
				using (FileStream destinationFile =
					new FileStream(@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\CopyBinaryFile\copiedfile.png",
					FileMode.Create))
				{
					byte[] buffer = new byte[4096];

					while (true)
					{
						int readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);

						if (readBytesCount == 0)
						{
							break;
						}

						destinationFile.Write(buffer, 0, buffer.Length);
					}
				}
			}
		}
	}
}
