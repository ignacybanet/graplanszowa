using System;
using System.Collections.Generic;

namespace enemy;


public class Enemy { 

    
    public string EnemyName;
    public int EnemyHealth;
    public int EnemyDamage;

    public Enemy(string name, int dmg, int hp) {
        EnemyName = name;
        EnemyDamage = dmg;
        EnemyHealth = hp;
    }


}


