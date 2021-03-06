﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public class Game
    {
        //                  MEMBER VARIABLES (WHAT IT HAS)
        public int roundCount;
        public List<Player> players;
        public Player playerOne;
        public Player playerTwo;

        //                  CONSTRUCTOR (SPAWNER)
        public Game()
        {
            this.roundCount = 0;
            players = new List<Player>();
        }

        //                  MEMBER METHODS (WHAT IT CAN DO)
        public void AskForGesture(string currentPlayer)
        {
            Console.WriteLine(currentPlayer + " Please type your selected gesture and press Enter");
            Console.WriteLine("\nChoose from: ROCK - PAPER - SCISSORS - LIZARD - SPOCK");
        }

        public void CreatePlayers(string modeSelection)
        {
            playerOne = new HumanPlayer();
            players.Add(playerOne);

            switch (modeSelection)
            {
                case "1":                    
                    playerTwo = new ComputerPlayer();
                    players.Add(playerTwo);
                    break;
                case "2":                    
                    playerTwo = new HumanPlayer();
                    players.Add(playerTwo);
                    break;
                default :
                    CreatePlayers(InitialMenu());
                    break;
            }
        }

        public string InitialMenu()
        {
            Console.Clear();
            Console.WriteLine("--- ROCK PAPER SCISSORS LIZARD SPOCK ---");
            Console.WriteLine("\nEnter 1 for Singleplayer or 2 for Multiplayer");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public void ShowScore()
        {
            Console.WriteLine("Player 1: " + playerOne.score);
            Console.WriteLine("Player 2: " + playerTwo.score + "\n");
        }

        public void PlayAgain()
        {
            Console.WriteLine("\nPress Enter to play again");
            Console.ReadLine();
            ExecuteGameFlow();
        }

        public void AnnounceWinner(Player player1, Player player2)
        {
            if (player1.score >= 2)
            {
                Console.WriteLine("Player 1 has won the game!");
                PlayAgain();
            }
            else if (player2.score >= 2)
            {
                Console.WriteLine("Player 2 has won the game!");
                PlayAgain();
            }            
        }

        public void DisplayRound()
        {
            Console.WriteLine("--- Round " + roundCount + " ---");
        }

        public void gestureCompare(string player1gesture, string player2gesture, Player player1, Player player2)
        {
            //Player 1 round victory cases
            if (player1gesture == player1.gestures[0] && player2gesture == player2.gestures[2])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " crushes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[2] && player2gesture == player2.gestures[1])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " cuts Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[1] && player2gesture == player2.gestures[0])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " covers Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[0] && player2gesture == player2.gestures[3])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " crushes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[3] && player2gesture == player2.gestures[4])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " poisons Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[4] && player2gesture == player2.gestures[2])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " smashes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[2] && player2gesture == player2.gestures[3])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " decapitates Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[3] && player2gesture == player2.gestures[1])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " eats Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[1] && player2gesture == player2.gestures[4])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " disproves Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[4] && player2gesture == player2.gestures[0])
            {
                Console.WriteLine("\nPlayer 1's " + player1gesture + " vaporizes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            //player 2 round victory cases
            else if (player2gesture == player2.gestures[0] && player1gesture == player1.gestures[2])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " crushes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[2] && player1gesture == player1.gestures[1])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " cuts Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[1] && player1gesture == player1.gestures[0])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " covers Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[0] && player1gesture == player1.gestures[3])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " crushes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[3] && player1gesture == player1.gestures[4])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " poisons Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[4] && player1gesture == player1.gestures[2])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " smashes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[2] && player1gesture == player1.gestures[3])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " decapitates Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[3] && player1gesture == player1.gestures[1])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " eats Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[1] && player1gesture == player1.gestures[4])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " disproves Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[4] && player1gesture == player1.gestures[0])
            {
                Console.WriteLine("\nPlayer 2's " + player2gesture + " vaporizes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            //tie round case
            else if (player2gesture == player1gesture)
            {
                Console.WriteLine("\nThis round was a tie!");
            }
            //edge case
            else
            {
                Console.WriteLine("\nError comparing player gestures");
            }
        }
        public void ExecuteGameFlow()
        {
            CreatePlayers(InitialMenu());

            roundCount = 0;
            playerOne.score = 0;
            playerTwo.score = 0;

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                string player1Move;
                string player2Move;
                roundCount++;

                AskForGesture("Player 1");
                player1Move = playerOne.PickGesture();

                if (playerTwo is HumanPlayer)
                {
                    AskForGesture("\nPlayer 2");
                    player2Move = playerTwo.PickGesture();
                }
                else
                {
                    player2Move = playerTwo.PickGesture();
                }                   

                Console.Clear();
                DisplayRound();
                gestureCompare(player1Move, player2Move, playerOne, playerTwo);
                ShowScore();
            }
            AnnounceWinner(playerOne, playerTwo);
        }
    }
}
