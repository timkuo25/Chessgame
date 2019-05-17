using System;

namespace Chessgame
{   
    class Knight : Piece
    {
        public Knight(int I, int J, bool team)
        {
            id = "Knight";
            this.I = I;
            this.J = J;
            this.team = team;
            this.alive = true;
        }
        public override void show()
        {
            Console.Write("Kn");
            
        }
    }
}
