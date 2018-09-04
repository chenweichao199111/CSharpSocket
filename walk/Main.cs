using System;
using System.Net;
using System.Net.Sockets;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");
		Serv serv = new Serv();
		serv.Start("127.0.0.1", 1234);
		
		while (true)
		{
			string str = Console.ReadLine();
			switch (str)
			{
			case "quit":
				return;
			}
		}
	}
}