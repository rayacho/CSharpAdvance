using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculations
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] reminder = input.Split(' ');
			Stack<string> stack = new Stack<string>(reminder.Reverse());

			while (stack.Count > 1)
			{
				int firstNumber = int.Parse(stack.Pop());
				string op = stack.Pop();
				int secondNumber = int.Parse(stack.Pop());

				if (op == "+")
				{
					stack.Push((firstNumber + secondNumber).ToString());
				}
				else
				{
					stack.Push((firstNumber - secondNumber).ToString());
				}
			}

			string result = stack.Pop();
			Console.WriteLine(result);
		}
	}
}
