using System;
namespace SelectionStatements
{
	public class Methods
	{
		public static void Exercise1()
		{
			var rand = new Random();
			int favNum = rand.Next(1, 100);
			Console.WriteLine("Guess my favorite number");
			var userNum = int.Parse(Console.ReadLine());


			if (userNum < favNum)
			{
				Console.WriteLine("too low");
			}

			else if (userNum > favNum)
			{
				Console.WriteLine("too high");
			}

			else
			{
				Console.WriteLine("You read my mind!");
			}
		}
	}
}

