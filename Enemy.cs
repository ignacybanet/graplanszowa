using System;
using System.Collections.Generic;

namespace enemy;


public class Enemy { 

    
    string EnemyName;
    int EnemyHealth;
    int EnemyDamage;

    public Enemy(string name, int dmg, int hp) {
        EnemyName = name;
        EnemyDamage = dmg;
        EnemyHealth = hp;
    }


}


