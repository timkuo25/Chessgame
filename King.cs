using System;

namespace Chessgame
{   
    class King : Piece
    {
        public King(int I, int J, bool team)
        {
            id = "King";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
        }
        public override void show()
        {
            Console.Write("K");
        }
    }
}
