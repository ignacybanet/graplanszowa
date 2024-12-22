using System;
using System.Collections.Generic;
using graplanszowa;

namespace player;

class Player{
    
    public string PlayerName;
    public int PlayerPosition;
    public int PlayerScore;

    public Player(string name) {
        PlayerName = name;
        PlayerPosition = 0;
        PlayerScore = 0;
    }

    public void MovePlayer() {
        //PlayerPosition+=RolledScore;
    }

    public void UpdateScore() {
        
    }

}