using System;

namespace GameEngine
{
    public class Class1
    {        
        public int countOfPlayer;
        public string player;

        public int gamePiece1;
        public int gamePiece2;
        public int gamePiece3;
        public int gamePiece4;


        public void GameStart()
        {
            Console.WriteLine("How many players?");
            int countOfPlayer = int.Parse(Console.ReadLine());


            if (countOfPlayer <= 4)
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
        }

        public static RollDice()
        {
            Random randomNr = new Random();
            int rand_dice = randomNr.Next(1, 7);
        }

        public static Player()
        {
            //antal steg från mål på vajre pjäs
            gamePiece1 = 30;
            gamePiece2 = 30;
            gamePiece3 = 30;
            gamePiece4 = 30;
        }

    }
}
