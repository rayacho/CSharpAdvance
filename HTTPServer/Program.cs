using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	static void Main(string[] args)
	{
		IPAddress address = IPAddress.Parse("127.0.0.1");
		int port = 8081;

		TcpListener tcpListener = new TcpListener(address, port);
		tcpListener.Start();

		Console.WriteLine($"Listening to TCP clients at 127.0.0.1:{port}");

		Task.Run(async () => await Connect(tcpListener));

		Console.ReadLine();
	}

	public static async Task Connect(TcpListener tcpListener)
	{
		Console.WriteLine("Waiting for client...");

		while (true)
		{
			TcpClient client = await tcpListener.AcceptTcpClientAsync();

			Console.WriteLine("Client connected.\n");

			byte[] buffer = new byte[1024];

			await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

			string message = Encoding.ASCII.GetString(buffer);

			Console.WriteLine(message);

			byte[] response = Encoding.ASCII.GetBytes("<body><h1>Hello from server!</h1></body>");

			await Task.Delay(5000);

			await client.GetStream().WriteAsync(response, 0, response.Length);

			Console.WriteLine("Closing connection");

			client.GetStream().Dispose();
		}
	}
}