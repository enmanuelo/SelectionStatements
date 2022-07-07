using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int favNum = rand.Next(1, 1000);
            Console.WriteLine("Guess my favorite number: ");
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
