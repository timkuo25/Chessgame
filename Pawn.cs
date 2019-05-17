using System;

namespace Chessgame
{   
    class Pawn : Piece
    {
        public Pawn(int I, int J, bool team)
        {
            id = "Pawn";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
            this.first_move = true;
        }

        public override void show()
        {
            Console.Write("P");
        }
    }
}
