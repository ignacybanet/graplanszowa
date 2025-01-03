using System;
using System.Collections.Generic;
using graplanszowa;

namespace player;


public interface InterfacePlayerClass {
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }
    public int Stamina { get; set; }
}

public class Warrior : InterfacePlayerClass {
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }
    public int Stamina { get; set; }

    public Warrior() {
        Health = 20;
        Damage = 20;
        Stamina = 10;
        Mana = 0;
    }

    // TODO: Dodać jakąś specjalną moc czy cos
}

public class Wizard : InterfacePlayerClass {
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }
    public int Stamina { get; set; }

    public Wizard() {
        Health = 15;
        Damage = 5;
        Stamina = 5;
        Mana = 25;
    }

    // TODO: Dodać jakąś moc znowu
}

public class Healer : InterfacePlayerClass {
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }
    public int Stamina { get; set; }

    public Healer() {
        Health = 15;
        Damage = 10;
        Stamina = 10;
        Mana = 15;
    }

    public void Heal() {
        // Tutaj jest dużo do zmiany
        if(Health <= 5 && Mana == 15) {
            Console.WriteLine("You are low on health! But you used your mana to heal you back to 15 health!");
            Mana -= 15;
            Health = 15;
        }
    }
}


class Player {
    
    public string PlayerName;
    public int PlayerPosition;
    public int PlayerScore;

    public object playerClass { get; set; }

    public Player(string name, object clas) {
        PlayerName = name;
        PlayerPosition = 0;
        PlayerScore = 0;
        playerClass = clas;
    }


    public void MovePlayer() {
        //PlayerPosition+=RolledScore;
    }

    public void UpdateScore(int score) {
        PlayerScore += score;
    }
    
}