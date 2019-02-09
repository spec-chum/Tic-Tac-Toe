using System;

namespace TTT
{
    internal class Player
    {
        private readonly Board Board;

        public Player(char symbol, Board gameBoard)
        {
            Symbol = symbol;
            Board = gameBoard;
        }

        public bool IsValidMove { get; private set; }
        public char Symbol { get; }

        public void GetMove()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad7:
                    UpdateBoard(0, 0);
                    break;

                case ConsoleKey.NumPad8:
                    UpdateBoard(1, 0);
                    break;

                case ConsoleKey.NumPad9:
                    UpdateBoard(2, 0);
                    break;

                case ConsoleKey.NumPad4:
                    UpdateBoard(0, 1);
                    break;

                case ConsoleKey.NumPad5:
                    UpdateBoard(1, 1);
                    break;

                case ConsoleKey.NumPad6:
                    UpdateBoard(2, 1);
                    break;

                case ConsoleKey.NumPad1:
                    UpdateBoard(0, 2);
                    break;

                case ConsoleKey.NumPad2:
                    UpdateBoard(1, 2);
                    break;

                case ConsoleKey.NumPad3:
                    UpdateBoard(2, 2);
                    break;
            }
        }

        private void UpdateBoard(int i, int j)
        {
            if (IsValidMove = Board.Update(i, j, Symbol))
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("                           ");
            }
            else
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Invalid move!  Try again...");
            }
        }
    }
}