using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();
			Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
			string line = Console.ReadLine();

			while (line != "Output")
			{
				string[] tokens = line.Split().ToArray();
				string dep = tokens[0];
				string dfn = tokens[1] + " " + tokens[2];
				string patient = tokens[3];
				if (!departments.ContainsKey(dep))
				{
					departments[dep] = new List<string>();
				}

				departments[dep].Add(patient);
				if (!doctors.ContainsKey(dfn))
				{
					doctors[dfn] = new List<string>();
				}

				doctors[dfn].Add(patient);
				line = Console.ReadLine();
			}
			line = Console.ReadLine().Trim();
			while (line != "End")
			{
				string[] token = line.Split().ToArray();
				if (token.Length == 1)
				{
					foreach (string patients in departments[line])
					{
						Console.WriteLine(patients);
					}
				}
				else if (int.TryParse(token[1], out int result))
				{
					if (int.Parse(token[1]) > 20)
					{
						continue;
					}
					List<string> patients = departments[token[0]];
					var room = patients.Skip(3 * (int.Parse(token[1]) - 1)).Take(3).OrderBy(p => p);

					foreach (string patient in room)
					{
						Console.WriteLine(patient);
					}
				}
				else
				{
					List<string> pat = doctors[line];
					pat.Sort();
					foreach (string patient in pat)
					{
						Console.WriteLine(patient);

					}
				}
				line = Console.ReadLine();
			}
		}
	}
}