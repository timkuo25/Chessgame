using System;

namespace Chessgame
{   
    abstract class Piece
    {
        protected string id;
        protected int I;
        protected int J;
        protected bool team; //true as black, false as white
        protected bool alive;
        protected bool first_move; //only used by pawns

        public Piece(){}
        public bool getTeam(){return team;}
        public bool getFirstMove(){return first_move;}
        public string getID(){return id;}
        
        public abstract void show();
        public void setFirstMove(){first_move = false;}
    }
}
