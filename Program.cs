using System;
using System.Collections.Generic;
using graplanszowa;
using game;
using board;
using player;

namespace graplanszowa;

class Program {
    static void Main(string[] args) {
        Board board = new Board(150);
        board.GenerateSpecialFields();
    }
}