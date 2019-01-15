using System;

namespace GameEngine
{
    public class Game
    {        
        public int GameStart()
        {
            Console.WriteLine("How many players?");
            int countOfPlayer = int.Parse(Console.ReadLine());

            //if players are more than 4 or less than , let the user entar a new value..
            while (countOfPlayer > 4 || countOfPlayer <= 1)
            {
                //if players are more than 4, tell user that there are to many players
                if (countOfPlayer > 4)
                {
                    Console.WriteLine("To many players... \n please enter a value under 5");
                    countOfPlayer = int.Parse(Console.ReadLine());

                } //if the players are less then 1, tell the users that there are to few playeZ¨|LOL
                else if ( countOfPlayer <= 1) 
                {
                    Console.WriteLine("To few players... \n please enter a value over 1");
                    countOfPlayer = int.Parse(Console.ReadLine());
                }
            }
            //when the players are between 0 and 4 the loop exits and code goes on
            Console.WriteLine("Get Ready! \nPress 1 to start the game! ");

            if (int.Parse(Console.ReadLine()) == 1)

            {
                Console.WriteLine("Game start");

                //we return countOfPlayer because the user entered 1, indicating that the user wants to play and call the next function in program.cs (RollDice)
                return countOfPlayer;
            }
            else
            {
                //we return 0 if the user did not want to roll the dice or said something othere than "1"
                return 0;
            }

        }
        public void RollDice()
        {

           
        }
    }
}
