using System;
using System.Collections.Generic;
using GameEngine;
namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            List<Player> playerList = new List<Player>();
            // om variablen nedan aktiveras genom att spelaren i tidigare skede skriver in 1 så kommer nedan kod att köras. class.1gamestart låter spelet starta    
            var numberOfPlayers = class1.GameStart();

            if (numberOfPlayers > 0)
            {
                for (int i = 0; i < numberOfPlayers; i++)
                {
                Console.WriteLine(("Type the Name of Player: "));
                var playerName = Console.ReadLine();
                    
                    //Create new player
                    Player player = new Player();

                    var gamePiece1 = new GamePiece();
                    player.gamePieces.Add(gamePiece1);

                    var gamePiece2 = new GamePiece();
                    player.gamePieces.Add(gamePiece2);

                    var gamePiece3 = new GamePiece();
                    player.gamePieces.Add(gamePiece3);

                    var gamePiece4 = new GamePiece();
                    player.gamePieces.Add(gamePiece4);

                    player.PlayerName = playerName;

                    playerList.Add(player);
                }
                Console.WriteLine("The players are: \n");
                foreach (var p in playerList)
                {

                    Console.WriteLine(">>  " + p.PlayerName);
                }

                //skapa metod för att köra en runda..
                //starta första "tärningskastet"
                foreach (var p in playerList)
                {
                    Console.WriteLine("It's " + p.PlayerName + "'s turn..");
                    p.RollTheDice(p,p.gamePieces[0]);
                }
                    Console.ReadKey();
            }

            else
            {
                   Console.WriteLine("You pressed something else besides 1, you suck major dicks");
             };

        }
    }
}
