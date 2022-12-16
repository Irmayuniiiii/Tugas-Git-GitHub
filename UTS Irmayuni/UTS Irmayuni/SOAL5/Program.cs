using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] board = new int[9];
            board [0] = 0;
            board [1] = 0;
            board [2] = 0;
            board [3] = 2;
            board [4] = 0;
            board [5] = 0;
            board [6] = 0;
            board [7] = 0;
            board [8] = 0;
            board [9] = 1;

            for( int i = 0; i < 9; i++)
            {
                //print the board
                //Console.WriteLine("Kotak" + i + " Berisi" + board[i]);

                //print x or o each square
                //0 means unoccuoied.1 means player 1 (X) 2 means player 2
            }

        }
    }
}
