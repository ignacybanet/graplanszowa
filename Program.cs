using System;
using System.Collections.Generic;

namespace graplanszowa;

class Program {

    
    class Player {
        public string Name;
        public string Position;
        public int Score;
         
        static void MovePlayer(string playerName) {
            // kod
        }

        public int RollDice() { // zrobione
            Random rnd = new Random();
            int RolledValue = rnd.Next(1,6);
            return RolledValue;
        }
    }

    class Board {
        // konstruktor dla planszy

        public int BoardSize;
        public int[] BoardSpecial;

        public Board(int size = 100) {
            
            if(size <= 0) {
                Console.WriteLine("Plansza jest za mala");
            }
            else { 
                BoardSize = size; 
            }

        }

        public void GenerateBoard() {
        
            int specialAmount = BoardSize / 6;
            BoardSpecial = new int[specialAmount + 1];
            Random rnd = new Random();

            for(int i = 0 ; i != BoardSpecial.Length ; i++) {
                BoardSpecial[i] = rnd.Next(BoardSize);
            }
            
        }

    }

    class Game {
        public void ManageGame() {
            // kod
        }

        static void CheckForSpecialPlace() {
            // sprawdzenie czy w danym miejscu jest specjalne pole
        }

        public void ShowResults() {
            // kod
        }
    }

    
    // -------przerwa-------


    static void Main(string[] args) {
        // kod
    }

}