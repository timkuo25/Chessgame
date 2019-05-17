using System;

namespace Chessgame
{   
    class Queen : Piece
    {
        public Queen(int I, int J, bool team)
        {
            id = "Queen";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
        }
        public override void show()
        {
            Console.Write("Q");
        }
    }
}
