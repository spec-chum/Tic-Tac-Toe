using System;

namespace TTT
{
    internal class Board
    {
        private readonly char[][] Grid = new char[3][]
        {
            new char[3],
            new char[3],
            new char[3]
        };

        public int SpacesLeft { get; private set; } = 9;

        public bool CheckWinCondition(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Check horizontal wins
                if (Grid[i][0] == player.Symbol && Grid[i][1] == player.Symbol && Grid[i][2] == player.Symbol)
                {
                    return true;
                }

                // Check vertical wins
                if (Grid[0][i] == player.Symbol && Grid[1][i] == player.Symbol && Grid[2][i] == player.Symbol)
                {
                    return true;
                }
            }

            // Check diagonals
            if (Grid[0][0] == player.Symbol && Grid[1][1] == player.Symbol && Grid[2][2] == player.Symbol)
            {
                return true;
            }

            if (Grid[2][0] == player.Symbol && Grid[1][1] == player.Symbol && Grid[0][2] == player.Symbol)
            {
                return true;
            }

            // Check if we've filled the board
            if (SpacesLeft == 0)
            {
                SpacesLeft--;   // set to -1 so indicate draw
                return true;
            }

            return false;
        }

        public void Draw()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 1);

            Console.WriteLine($" {Grid[0][0]} | {Grid[1][0]} | {Grid[2][0]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {Grid[0][1]} | {Grid[1][1]} | {Grid[2][1]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {Grid[0][2]} | {Grid[1][2]} | {Grid[2][2]} ");
        }

        public bool Update(int i, int j, char symbol)
        {
            // Make sure space is clear
            if (Grid[i][j] == 0)
            {
                Grid[i][j] = symbol;
                SpacesLeft--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}