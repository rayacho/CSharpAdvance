using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateParty
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<string, string> Double = name => $"{name}, {name} ";
			Func<string, string> Remove = name => name = "";
			string[] people = Console.ReadLine().Split(' ');
			string[] command = {"", "", "" };
			int times = 0;

			while (command[0] != "Party!")
			{
				command = Console.ReadLine().Split(' ');
				string thing = command[2];
				int length = thing.Length;

				switch (command[0])
				{
					case "Double":
						{
							switch (command[1])
							{
								case "StartsWith":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].StartsWith(thing))
											{
												Console.Write(Double(people[i]));
												times++;
											}
										}
									}
									break;
								case "EndsWith":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].EndsWith(thing))
											{
												Console.Write(Double(people[i]));
												times++;
											}
										}
									}
									break;
								case "Length":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].Length == length)
											{
												Console.Write(Double(people[i]));
												times++;
											}
										}
									}
									break;
							}
						}
						break;
					case "Remove":
						{
							switch (command[1])
							{
								case "StartsWith":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].StartsWith(thing))
											{
												Console.Write(Remove(people[i]));
												times++;
											}
										}
									}
									break;
								case "EndsWith":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].EndsWith(thing))
											{
												Console.Write(Remove(people[i]));
												times++;
											}
										}
									}
									break;
								case "Length":
									{
										for (int i = 0; i < people.Length; i++)
										{
											if (people[i].Length == length)
											{
												Console.Write(Remove(people[i]));
												times++;
											}
										}
									}
									break;
							}
						}
						break;
				}
				if (times >= 2)
				{
					Console.WriteLine(" are going to the party!");
				}
				else if(times == 1)
				{
					Console.WriteLine(" is going to the party!");
				}
				else if(times == 0)
				{
					Console.WriteLine("Nobody is going to the party!");
				}
			}
		}
	}
}

