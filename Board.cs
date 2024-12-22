using System;
using System.Collections.Generic;
using graplanszowa;

namespace board;


class Board{
    
    public int BoardSize;
    public List<int> SpecialFields;


    public Board(int size = 100) {
        BoardSize = size;
        SpecialFields = new List<int>();
    }

    public void GenerateSpecialFields() {

        SpecialFields = new List<int>();
        
        Random rnd = new Random();
        int SFamount = Convert.ToInt32(Math.Round( BoardSize  / 7.59 ));
        int randomField;
        
        for(int i = 0; i != SFamount; i++) {
            randomField = rnd.Next(1, BoardSize);
            if(SpecialFields.Contains(randomField)) {
                i--;
            } else {
                SpecialFields.Add(randomField);
            }
           
            
        }
    }
    
}