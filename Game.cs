using System;
using System.Collections.Generic;
using player;
using board;
using System.Diagnostics.CodeAnalysis;

namespace game;


class Game {
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

    List<Player> players = new List<Player>();

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
    Board board = new Board(boardSize);
    PlayerTurn();
    }



    static void PlayerTurn() {
        bool gameStarted = true;
        
        while (!gameStarted) {
            
        }
    }

    // public void SpecialFieldChecker(Player player, Board board) {
        
    //     if( board.SpecialFields.Contains(player.PlayerPosition) ) {

    //         player.UpdateScore();

    //     }
    // }

    // public void ShowResults() {
        
    // }
}


