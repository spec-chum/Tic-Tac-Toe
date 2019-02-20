using System;

namespace TTT
{
    internal static class Program
    {
        private static void Main()
        {
            var board = new Board();
            var playerX = new Player('X', board);
            var playerO = new Player('O', board);
            var currentPlayer = playerO;

            board.Draw();

            while (!board.CheckWinCondition(currentPlayer))
            {
                currentPlayer = currentPlayer == playerX ? playerO : playerX;

                do
                {
                    currentPlayer.GetMove();
                } while (!currentPlayer.IsValidMove);

                board.Draw();
            }

            Console.SetCursorPosition(0, 8);
            if (board.SpacesLeft == -1)
            {
                Console.WriteLine("Draw!\n\n");
            }
            else
            {
                Console.WriteLine($"{currentPlayer.Symbol} wins!\n\n");
            }

            Console.ReadLine();
        }
    }
}