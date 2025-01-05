using System;
using System.Collections.Generic;
using graplanszowa;
using enemy;
using System.IO.Pipes;

namespace board;



class Board{

    public int BoardSize;
    public Dictionary<int, Enemy> EnemyFields;
    public List<int> SpecialFields;

    public Board(int size = 100) {
        BoardSize = size;
        EnemyFields = new Dictionary<int, Enemy>();
        SpecialFields = new List<int>();
    }

    public void GenerateFields() {
        Random rnd = new Random();
        int EFamount = Convert.ToInt32(Math.Round( BoardSize  / 7.34)) ;
        int randomField;
        int randomMonster;

        for(int i = 0; i != EFamount; i++) {
            randomField = rnd.Next(4, BoardSize);
            randomMonster = rnd.Next(1,4);

            if(EnemyFields.ContainsKey(randomField)) {
                i--;
            } else {
                if(randomMonster == 1) {
                    EnemyFields.Add(randomField, new Enemy("Skelton", 3, 15));
                }
                else if(randomMonster == 2) {
                    EnemyFields.Add(randomField, new Enemy("Zombie", 5, 25));
                }
                else if(randomMonster == 3) {
                    EnemyFields.Add(randomField, new Enemy("Slime", 2, 10));
                }
            }

            

        }

        int SFamount = Convert.ToInt32(Math.Round( BoardSize  / 7.34));
        randomField = 0;

        for(int i = 0; i != SFamount; i++) {
            randomField = rnd.Next(1, BoardSize);
            
            if( SpecialFields.Contains(randomField) || EnemyFields.ContainsKey(randomField) ) {
                i--;
                
            } else {
                SpecialFields.Add(randomField);
            }
            
        }


        

    }
    
}