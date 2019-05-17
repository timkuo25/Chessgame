using System;

namespace Chessgame
{
    class Program
    {
        static void Main()
        {
            Console.Write("Welcome to Chess game\n");
            Board a = new Board();

            a.show();
            a.move(1, 7, 3, 7);
            a.move(0, 7, 2, 7);
            a.move(2, 7, 3, 6);
            a.move(2, 7, 2, 0);
            a.move(2, 0, 6, 0);
            a.move(6, 0, 4, 2);

            Console.ReadLine();
        }
    }
}
