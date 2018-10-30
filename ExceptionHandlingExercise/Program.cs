using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			bool validAnswer = false;
			int userAge = 0;
			try
			{
				while (!validAnswer)
				{
					Console.WriteLine("Hello, How old are you or will you be this year?");
					validAnswer = int.TryParse(Console.ReadLine(), out userAge);
					if (!validAnswer) Console.WriteLine("Please enter whole number only! No decimals. Thank you.");

				}
				if (userAge <= 0)
				{
					throw new Exception();
				}
				int birthYear = 2018 - userAge;

				Console.WriteLine("You were born in " + birthYear + ".");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Please enter positive whole number digits only, no decimal numbers, zero, or negative numbers.");
				Console.ReadLine();
				return;
			}

		}
	}
}
