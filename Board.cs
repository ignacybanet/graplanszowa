using System;
using System.Collections.Generic;
using graplanszowa;
using enemy;
using System.IO.Pipes;

namespace board;



class Board{

    public int BoardSize;
    public Dictionary<int, Enemy> SpecialFields;

    public Board(int size = 100) {
        BoardSize = size;
        SpecialFields = new Dictionary<int, Enemy>();
    }

    public void GenerateSpecialFields() {
        Random rnd = new Random();
        int SFamount = Convert.ToInt32(Math.Round( BoardSize  / 7.59 ));
        int randomField;
        int randomMonster;

        for(int i = 0; i != SFamount; i++) {
            randomField = rnd.Next(1, BoardSize);
            randomMonster = rnd.Next(1,4);

            if(randomMonster == 1) {
                SpecialFields.Add(randomField, new Enemy("Skelton", 3, 15));
            }
            else if(randomMonster == 2) {
                SpecialFields.Add(randomField, new Enemy("Zombie", 5, 25));
            }
            else if(randomMonster == 3) {
                SpecialFields.Add(randomField, new Enemy("Slime", 2, 10));
            }

            // Są tzy potwory (szkielet, zombie, slime)

        
        }

    }
    
}