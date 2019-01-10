using System;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int nrOfPlayer;

            Console.WriteLine("How many player?");
            int countOfPlayer = int.Parse(Console.ReadLine());

            string player;

            if (nrOfPlayer <= 4)
            {
                Console.WriteLine("Game start");
            }
            else
            {
                Console.WriteLine("To many player...");
                // vill att man ska kunna fortsätta att skriva in hur många spelare man är om man blir för många....
                //Console.WriteLine("How many player?");
                //nrOfPlayer = int.Parse(Console.ReadLine());
            }

            Random randomNr = new Random();
            int rand_dice = randomNr.Next(1, 7);


            Console.ReadKey();
        }
    }
}
