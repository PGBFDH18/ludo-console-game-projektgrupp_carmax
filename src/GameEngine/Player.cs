using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Player
    {
        //egenskaper för varje spelare
        //Namn på spelare
        public string PlayerName { get; set; }

        // Lista för Spelpjäser (varje spelare skall ha en lista av sina spelpjäser ihihihihihhihihihihiihihhihihihihihihihihihihihihihihihihih) 
        public List<GamePiece> gamePieces = new List<GamePiece>();

        // rollhedice metod på playerklassen
        public void RollTheDice(Player player, GamePiece GamePiece)
        {
            Random randomNr = new Random();
            int rand_dice = randomNr.Next(1, 7);
            Console.WriteLine("Your roll of the dice is: " + rand_dice);

            if (rand_dice == 6)
            {
                //if(man har två > boet)
                Console.WriteLine("What do you want to do?");

                Console.WriteLine();
                Console.WriteLine("1. Enter with two Game Pieces? ");
                Console.WriteLine("2. Go six steps forward? ");
                Console.WriteLine("3. choose another game piece to move?");

                //playser chooses option
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("you chose to enter with two Game Pieces!");
                        //do something..
                        break;
                    case 2:
                        Console.WriteLine("you chose to take six steps forward!");
                        //do something.. 
                        break;
                    case 3:
                        Console.WriteLine("you chose to move another gamepiece!");
                        //do something..
                        break;
                }

                //Do something with the player choice...
            }
            else
            {
                Console.WriteLine("You rolled a " + rand_dice);
                var remainingSteps = player.gamePieces[0].RemoveStepsToGoal(rand_dice);
                //do Something... subtract rolled value from gamepiece
                Console.WriteLine(player.PlayerName + " has moved his/her gamepiece " + rand_dice +  " steps." + " Reamaining steps is: " + remainingSteps + Environment.NewLine);
            }
        }   
    }
    public class GamePiece
    {
        int StepsToGoal = 40;

        public string RemoveStepsToGoal (int steps)
        {
            var remainingSteps = StepsToGoal - steps;
            return remainingSteps.ToString();
        }
    }
}
