using System;

namespace Chessgame
{   
    class Rook : Piece
    {
        public Rook(int I, int J, bool team)
        {
            id = "Rook";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
        }
        public override void show()
        {
            Console.Write("R");
        }
    }
}
