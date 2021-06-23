using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Can you guess my favorite number?");

            var r = new Random();
            var favoriteNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favoriteNumber)
            {
                Console.WriteLine("Too Low");

            }
            else if (userInput > favoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");

            }
        }

    }
}
