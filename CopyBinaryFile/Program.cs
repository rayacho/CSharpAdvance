using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
			using (var sourceFile = new FileStream(

				@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\copyMe.png", FileMode.Open))

			{

				using (var destinacionFile = new FileStream(

					@"C:\Users\RAYA CHORBADZHIYSKA\Desktop\CSharpAdvanced\CSharpAdvance\CopyBinaryFile\copiedfile.png", FileMode.Create))

				{

					byte[] buffer = new byte[4096];

					while (true)

					{

						var readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);

						if (readBytesCount == 0)

							break;
						
						destinacionFile.Write(buffer, 0, buffer.Length);

					}
					
				}

			}
		}
    }
}
