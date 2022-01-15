using System;

namespace TTT
{
    internal static class Program
    {
        private static void Main()
        {
            var playerX = new Player('X');
            var playerO = new Player('O');
            var currentPlayer = playerO;

            Board.Draw();

            while (!Board.CheckWinCondition(currentPlayer))
            {
                currentPlayer = currentPlayer == playerX ? playerO : playerX;

                do
                {
                    currentPlayer.GetMove();
                } while (!currentPlayer.IsValidMove);

                Board.Draw();
            }

            Console.SetCursorPosition(0, 8);
            if (Board.SpacesLeft == -1)
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