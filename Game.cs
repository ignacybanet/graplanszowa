using System;
using System.Collections.Generic;
using player;
using board;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using enemy;

namespace game;


class Game {


    static List<Player> players = new List<Player>();
    static Board board;

    public static void GameStart() {


        Console.WriteLine("Welcome to GoardSameBimulator! \nIn this game you can choose size of the board! \nThis game can handle up to 4 players");
        
        int playersAmount;
    do {
        Console.WriteLine("Choose amount of players (2-4):");
        playersAmount = Convert.ToInt32(Console.ReadLine());
        if (playersAmount < 2 || playersAmount > 4) {
            Console.WriteLine("Invalid amount of players. Please choose a number between 2 and 4.");
        }
    } while (playersAmount < 2 || playersAmount > 4);

    int boardSize;
    do {
        Console.WriteLine("Enter size of board (number between 8 and 1000): ");
        boardSize = Convert.ToInt32(Console.ReadLine());
        if (boardSize < 8 || boardSize > 1000) {
            Console.WriteLine("Invalid board size. Please choose a number between 8 and 1000.");
        }
    } while (boardSize < 8 || boardSize > 1000);

    

    for (int i = 1; i <= playersAmount; i++) {
        Console.WriteLine($"Enter name of player {i}:");
        string playerName = Console.ReadLine();

        int playerClass;
        do {
            Console.WriteLine($"Choose a character class:\n 1: Warrior\n 2: Wizard\n 3: Healer");
            playerClass = Convert.ToInt32(Console.ReadLine());
            switch (playerClass) {
                case 1:
                    Warrior warrior = new Warrior();
                    players.Add(new Player(playerName, warrior));
                    
                    break;
                case 2:
                    Wizard wizard = new Wizard();
                    players.Add(new Player(playerName, wizard));
                    break;
                case 3:
                    Healer healer = new Healer();
                    players.Add(new Player(playerName, healer));
                    break;
                default:
                    Console.WriteLine("Invalid character class. Please choose a number between 1 and 3.");
                    playerClass = 0; 
                    break;
            }
        } while (playerClass < 1 || playerClass > 3);
    }
    
    Console.WriteLine("Game setup complete!");
    Console.WriteLine("Your characters: ");
    players.ForEach(player => Console.WriteLine($"{player.PlayerName} - {player.playerClass.GetType().Name}"));
    
    board = new Board(boardSize);
    board.GenerateFields();
    
    PlayerTurn();
    
    }

    static void SpecialFieldChecker(Player player, Board board) {
        
        if(board.SpecialFields.Contains(player.PlayerPosition)) {
            Random rnd = new();
            int score = rnd.Next(2,4);
            Console.WriteLine($"Player {player.PlayerName} got lucky and received {score} points!");
            player.UpdateScore(score);
            Console.WriteLine($"{player.PlayerName} is now at {player.PlayerScore} points!");

        }
    }
    
    static void EnemyFieldChecker(Player player, Board board) {
        if (board.EnemyFields.ContainsKey(player.PlayerPosition)) {
            Console.WriteLine($"Player {player.PlayerName} just encountered an enemy!");
            Console.WriteLine("Now they can decide whether they want to fight or flight! (at a price)");
            int choice;
            do {
                Console.WriteLine("1: Fight\n2: Run");
                choice = Convert.ToInt32( Console.ReadLine() );
            } while(choice < 1 || choice > 2);


            if (choice == 1) {
                Enemy enemy = board.EnemyFields[player.PlayerPosition];
                Console.WriteLine($"The fight begins! Your enemy is {enemy}");
            }

            else if(choice == 2) {
                Console.WriteLine($"{player.PlayerName} decided to flee the battle! What a coward!\nThey are now 3 fields behind!");
                player.PlayerPosition -= 3;
                Console.WriteLine($"{player.PlayerName} is now on field {player.PlayerPosition}!");
            }

            else {
                Console.WriteLine("somehow you broke it idiot");
                EnemyFieldChecker(player, board);
            }
        }
    }
    
    static void PlayerTurn() {

        // Gracz n rzuca kostką i przemieszcz sie o x pól
        // Gracz sioe rusza i gra sprzwdza czy jest na ostatnim polu. Jeżeli tak, to gra się kończy i Gracz n jest zwycięzcą.
        // Gra sprawdza czy Gracz n jest na specjanym polu.
        // Jezeli tak, to walczy z przeciwnikiem (przeciwnik atakuje, po czym gracz atakuje, dopóki jeden z nich nie umrze.)
        // Jeżeli przeciwnik został pokonany Gracz n dostaje 5 punktow.
        // Jeżeli Gracz n przegrał bitwę, odejmowane są 3 punkty.
        // Gracz n po turze dostaje także +1 do many.

        bool gameStarted = true;
        
        


        while (gameStarted) {
            for(int i = 0 ; i < players.Count() ; i++) {
                Player currentPlayer = players[i];
                Random rnd = new Random();

                Console.WriteLine($"Player {currentPlayer.PlayerName} rolls the dice!");

                int diceRoll = rnd.Next(1,7);
                
                Console.WriteLine($"Player {currentPlayer.PlayerName } rolled {diceRoll}!");
                currentPlayer.MovePlayer(diceRoll);
                if(currentPlayer.PlayerPosition > 100) {currentPlayer.PlayerPosition = 100;}
                Console.WriteLine($"{currentPlayer.PlayerName} is now on field {currentPlayer.PlayerPosition}!");

                

                if(currentPlayer.PlayerPosition >= board.BoardSize) {
                    Console.WriteLine($"Congratulations {currentPlayer.PlayerName}! You won with {currentPlayer.PlayerScore} points");
                    gameStarted = false;
                    i = players.Count();
                    // ShowResults();
                }

                SpecialFieldChecker(currentPlayer, board);
                EnemyFieldChecker(currentPlayer, board);
            }
            
            
        }
    }

    //

    
}


