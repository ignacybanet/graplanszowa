using System;
using System.Collections.Generic;
using graplanszowa;

namespace player;


public interface InterfacePlayerClass {

    public string ClassName { get; set; }
    public int MaxHealth { get; set;}
    public int Health { get; set; }
    public int Damage { get; set; }
    public int MaxMana { get; set; }
    public int Mana { get; set; }

    public void SpecialAction () {}
}

public class Warrior : InterfacePlayerClass {
    public string ClassName { get; set; }
    public int MaxHealth { get; set;}
    public int Health { get; set; }
    public int Damage { get; set; }
    public int MaxMana { get; set; }
    public int Mana { get; set; }



    public Warrior() {
        ClassName= "Warrior";
        MaxHealth = 15;
        Health = 15;
        Damage = 10;
        MaxMana = 0;
        Mana = 0;
    }

    public void SpecialAction() {

    }
}

public class Wizard : InterfacePlayerClass {
    public string ClassName { get; set; }
    public int MaxHealth { get; set;}
    public int Health { get; set; }
    public int Damage { get; set; }
    public int MaxMana { get; set; }
    public int Mana { get; set; }
    


    public Wizard() {
        ClassName= "Wizard";
        MaxHealth = 15;
        Health = 15;
        Damage = 5;
        MaxMana = 15;
        Mana = 15;
    }

    public void SpecialAction() {
        if(Mana >= MaxMana) {
            Console.WriteLine("You used super mega duper uwu meteorite shower and dealt 300% of your damage");
            Mana -= 15;
            Damage *= 3;
        }
        else if (Damage == 15) {
            Damage /= 3;
        }
    }
}

public class Healer : InterfacePlayerClass {
    public string ClassName { get; set; }
    public int MaxHealth { get; set;}
    public int Health { get; set; }
    public int Damage { get; set; }
    public int MaxMana { get; set; }
    public int Mana { get; set; }


    public Healer() {
        ClassName= "Healer";
        MaxHealth = 15;
        Health = 15;
        Damage = 7;
        MaxMana = 15;
        Mana = 15;
    }

    public void SpecialAction() {
        if(Health <= 5 && Mana >= MaxMana) {
            Console.WriteLine("You are low on health! But you used your mana to heal you back to full!");
            Mana -= 15;
            Health = MaxHealth;
        }
    }
}


class Player {
    
    public string PlayerName;
    public int PlayerPosition;
    public int PlayerScore;

    public InterfacePlayerClass playerClass { get; set; }

    public Player(string name, InterfacePlayerClass clas) {
        PlayerName = name;
        PlayerPosition = 0;
        PlayerScore = 0;
        playerClass = clas;
    }


    public void MovePlayer(int positionIncrement) {
        PlayerPosition += positionIncrement;
    }

    public void UpdateScore(int score) {
        PlayerScore += score;
    }
    
}