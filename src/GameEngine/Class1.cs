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

        public void Player()
        {
            //antal steg från mål på varje pjäs
            gamePiece1 = 40;
            gamePiece2 = 40;
            gamePiece3 = 40;
            gamePiece4 = 40;
        }

        public void GameStart()
        {
            Console.WriteLine("How many players?");
            int countOfPlayer = int.Parse(Console.ReadLine());

            if (countOfPlayer <= 4)
            {
                Console.WriteLine("Game start");
                Console.WriteLine("Press 1 to roll the dice");
                int rollTheDice = int.Parse(Console.ReadLine());
                if (rollTheDice == 1)
                {
                    RollDice();
                }
            }
            else
            {
                Console.WriteLine("To many player...");
                // vill att man ska kunna fortsätta att skriva in hur många spelare man är om man blir för många....
                //Console.WriteLine("How many player?");
                //nrOfPlayer = int.Parse(Console.ReadLine());
            }
        }
        public void test()
        {
            Console.WriteLine("Which gamepiece do you wanna move?");
            Console.WriteLine("1. gamePiece1");
            Console.WriteLine("2. gamePiece2");
            Console.WriteLine("3. gamePiece3");
            Console.WriteLine("4. gamePiece4");

            //int whichPiece = int.Parse(Console.ReadLine());

            //if (whichPiece == 1)
            //{
            //    int test = gamePiece1 - rand_dice;
            //}

            //if (whichPiece == 2)
            //{
            //    int test = gamePiece2 - rand_dice;
            //}

            //if (whichPiece == 3)
            //{
            //    int test = gamePiece3 - rand_dice;
            //}

            //if (whichPiece == 4)
            //{
            //    int test = gamePiece4 - rand_dice;
            //}

            // måste kolla hur många man har i boet
            //if (gamePiece1 || GamePiece2 || GamePiece3 || Gamepiece4 > 40)
            //{
            //}
        }

        public void RollDice()
        {
            Random randomNr = new Random();
            int rand_dice = randomNr.Next(1, 7);
            Console.WriteLine("Your number is: " + rand_dice);

            if (rand_dice == 6)
            {
                //if(man har två > boet)
                Console.WriteLine("What do you want to do?");

                Console.WriteLine();
                Console.WriteLine("1. Enter with two Game Pieces? ");
                Console.WriteLine("2. Go six steps forward? ");
                Console.WriteLine("3. choose another game piece to move?");

                //int option = int.Parse(Console.ReadLine());

                
            }
            Console.ReadKey();
        }
    }
}
