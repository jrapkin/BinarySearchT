using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
	public static class UserInterface
	{

		public static int UserInput()
		{
			bool inputIsAnInteger = false;
			int userInput = 0;

			while (inputIsAnInteger == false)
			{
				inputIsAnInteger = Int32.TryParse(Console.ReadLine(), out userInput);
			}
			return userInput;
		}

		public static void DisplayMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}
