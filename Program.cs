using System;
using System.Collections.Generic;

namespace graplanszowa;

class Program {

    
    class Player {
        public string Name;
        public int Position;
        public int Score;
        public int Id;

        public Player(string playerName, int playerId) {
            Name = playerName;
            Id = playerId;
            Position = 0;
            Score = 0;
        }

         
        

        public int RollDice() { // zrobione
            Random rnd = new Random();
            int RolledValue = rnd.Next(1,6);
            return RolledValue;
        }

        public void MovePlayer(string playerName) { // jest juz git prosze nie zmieniac
            int IncrementPosition = RollDice();
            Position += IncrementPosition;
            Console.WriteLine($"Player {playerName} just moved by {IncrementPosition} fields.");
        }
    }

    class Board {
        
        public int BoardSize;
        public List<int> BoardSpecial;

        public Board(int size = 100) {
            
            if(size <= 0) {
                Console.WriteLine("Plansza jest za mala");
            }
            else { 
                BoardSize = size; 
            }

            BoardSpecial = new List<int>();
            

        }

        public void GenerateBoard() {
        
            int specialFieldsAmount = BoardSize / 6;
            Random rnd = new Random();

            for(int i = 0 ; i != specialFieldsAmount ; i++) {
                BoardSpecial.Add( rnd.Next(BoardSize) );
            }
            
        }

    }

    class Game {
        public void ManageGame() {
            // kod
        }

        public static void CheckForSpecialField(Player player, Board board) { // Funkcja przyjmuje gracza (typ danych Player) oraz plansze (typ danych Board)
            if( board.BoardSpecial.Contains( player.Position ) ) { // sprawdzenie czy w danym miejscu jest specjalne pole
                player.Score++;
                Console.WriteLine($"{player.Name} just entered a special field! \nTheir score has been incremented by 1!");
            }
        }

        public void ShowResults() {
            // kod
        }
    }

    
    // -------przerwa-------


    static void Main(string[] args) {
        // kod

        Player playerOne = new Player("Lukasz", 0);
    }

}