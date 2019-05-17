using System;

namespace Chessgame
{   
    class Bishop : Piece
    {
        public Bishop(int I, int J, bool team)
        {
            id = "Bishop";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
        }
        public override void show()
        {
            Console.Write("B");
            
        }
    }
}
