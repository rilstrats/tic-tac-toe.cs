﻿

namespace TicTacToe_cs
{
    class TicTacToe
    {

        static void Main()
        {
            Board board = new Board();
            Player player = new Player();

            for (int i = 1; i <= 9; i++)
            {
                board.DisplayBoard();
                player.TakeTurn(board.squares);
                if (board.WinCheck(player.current)) { board.DisplayWinner(player.current); return; }
                player.SwitchPlayer();
            }

            board.DisplayTie();

        }

    }
}