using System;

namespace Chessgame
{   
    class Board
    {
        private Piece[] black = new Piece[16];
        private Piece[] white = new Piece[16];
        private Piece[,] board = new Piece[8, 8];
        private bool legal(int p1, int p2, int p3, int p4) //legal movement
        {
            if(p3 < 0 || p3 > 7 || p4 < 0 || p4 > 7) return false; //out of range
            if(board[p1, p2] == null) return false; //no piece in  the cell

            if(this.board[p1, p2].getID() == "King")
            {
                if(Math.Abs(p1 - p3) + Math.Abs(p2 - p4) == 1)
                {
                    if(board[p3, p4] == null) return true;
                    else
                    {
                        if(board[p3, p4].getTeam() != board[p1, p2].getTeam()) return true;
                    }
                }
                return false;
            }
            else if(this.board[p1, p2].getID() == "Pawn")
            {
                if(this.board[p1, p2].getTeam()) //black
                {
                    if(this.board[p1, p2].getFirstMove())
                    {
                        if(p2 == p4 && (p3 - p1) == 2)
                        {
                            if(board[p3 - 1, p4] == null && board[p3, p4] == null)
                            {
                                this.board[p1, p2].setFirstMove();
                                return true;
                            }
                        }
                    }
                    if(p2 == p4 && (p3 - p1) == 1)
                    {
                        if(board[p3, p4] == null)
                        {
                            this.board[p1, p2].setFirstMove();
                            return true;
                        }
                    }
                    if((p3 - p1) == 1 && Math.Abs(p4 - p2) == 1)
                    {
                        if(board[p3, p4] != null)
                        {
                            this.board[p1, p2].setFirstMove();
                            return true;
                        } 
                    }
                    return false;
                }

                else //white
                {
                    if(this.board[p1, p2].getFirstMove())
                    {
                        if(p2 == p4 && (p1 - p3) == 2)
                        {
                            if(board[p3 + 1, p4] == null && board[p3, p4] == null)
                            {
                                this.board[p1, p2].setFirstMove();
                                return true;
                            }
                        }
                    }
                    if(p2 == p4 && (p1 - p3) == 1)
                    {
                        if(board[p3, p4] == null)
                        {
                            this.board[p1, p2].setFirstMove();
                            return true;
                        } 
                    }
                    if((p3 - p1) == 1 && Math.Abs(p4 - p2) == 1)
                    {
                        if(board[p3, p4] != null)
                        {
                            this.board[p1, p2].setFirstMove();
                            return true;
                        } 
                    }
                    return false;
                }
            }
            else if(this.board[p1, p2].getID() == "Rook")
            {
                if(p1 == p3 && p2 != p4)
                {
                    if(p2 < p4)
                    {
                        for(int i = p2 + 1; i < p4; i++)
                        {
                            if (board[p1, i] != null) return false;
                        }
                        if(board[p3, p4] == null) return true;
                        if (board[p3, p4].getTeam() == board[p1, p2].getTeam()) return false;
                        return true;
                    }
                    else
                    {
                        for(int i = p2 - 1; i > p4; i--)
                        {
                            if (board[p1, i] != null) return false;
                        }
                        if(board[p3, p4] == null) return true;
                        if (board[p3, p4].getTeam() == board[p1, p2].getTeam()) return false;
                        return true;
                    }   
                }

                else if(p1 != p3 && p2 == p4)
                {
                    if(p1 < p3)
                    {
                        for(int i = p1 + 1; i < p3; i++)
                        {
                            if (board[i, p2] != null) return false;
                        }
                        if(board[p3, p4] == null) return true;
                        if (board[p3, p4].getTeam() == board[p1, p2].getTeam()) return false;
                        return true;
                    }
                    else
                    {
                        for(int i = p1 - 1; i > p3; i--)
                        {
                            if (board[i, p2] != null) return false;
                        }
                        if(board[p3, p4] == null) return true;
                        if (board[p3, p4].getTeam() == board[p1, p2].getTeam()) return false;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public Board() //initialize the board
        {
            black[0] = new Rook(0, 0, true);
            white[0] = new Rook(7, 0, false);
            black[1] = new Knight(0, 1, true);
            white[1] = new Knight(7, 1, false);
            black[2] = new Bishop(0, 2, true);
            white[2] = new Bishop(7, 2, false);
            black[3] = new King(0, 3, true);
            white[3] = new King(7, 3, false);
            black[4] = new Queen(0, 4, true);
            white[4] = new Queen(7, 4, false);
            black[5] = new Bishop(0, 5, true);
            white[5] = new Bishop(7, 5, false);
            black[6] = new Knight(0, 6, true);
            white[6] = new Knight(7, 6, false);
            black[7] = new Rook(0, 7, true);
            white[7] = new Rook(7, 5, false);
            for(int i = 0; i < 8; i++)
            {
                black[8 + i] = new Pawn(1, i, true);
                white[8 + i] = new Pawn(6, i, false);
            }

            for(int i = 0; i < 8; i++)
            {
                board[0, i] = black[i];
                board[1, i] = black[8 + i]; //Pawn
                board[7, i] = white[i];
                board[6, i] = white[8 + i]; //Pawn
            }
            for(int i = 2; i < 6; i++)
            {
                for(int j = 0; j < 8; j++)
                    board[i, j] = null;
            }        
        }

        public void show() //show board on console. just for testing
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if(board[i,j] == null)
                    {
                        Console.Write(".\t");
                        continue;
                    }
                    board[i,j].show();
                    Console.Write("\t");
                }
                if(board[i,7] == null)
                {
                    Console.Write(".\n");
                    continue;
                }
                board[i,7].show();
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void move(int p1, int p2, int p3, int p4) //move piece on the board
        {
            if(!legal(p1, p2, p3, p4))
            {
                Console.WriteLine("(" + p1 + ", " + p2 + ") to (" + p3 + ", " + p4 +") is an Illegal Move\n");
                return;
            }
            Console.WriteLine("Move (" + p1 + ", " + p2 + ") to (" + p3 + ", " + p4 + ")");
            board[p3, p4] = board[p1, p2];
            board[p1, p2] = null;
            this.show();
        }
    }
}
