using System;
using System.Collections.Generic;
using player;
using board;

namespace game;


class Game {
    static void GameStart() {
        Console.WriteLine("Welcome to GoardSameBimulator! \nIn this game you can choose size of the board! \nThis game can handle up to 4 players");
        PlayerTurn();
    }

    static void PlayerTurn() {
        
    }

    public void SpecialFieldChecker(Player player, Board board) {
        
        if( board.SpecialFields.Contains(player.PlayerPosition) ) {

            player.UpdateScore();

        }
    }

    public void ShowResults() {
        
    }
}


