using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/529bf0e9bdf7657179000008
    public class Sudoku_Solution_Validator
    {
        public static bool ValidateSolution(int[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                int _count = 0;
                for (int j = 0; j < 9; j++)
                {
                    _count += board[i][j];
                }
                if (_count != 45) return false;
            }

            // |
            for (int i = 0; i < 9; i++)
            {
                int _count = 0;
                for (int j = 0; j < 9; j++)
                {
                    _count += board[j][i];
                }
                if (_count != 45) return false;
            }

            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count += board[j][i];
                }
            }
            if (count != 45) return false;

            return true;
        }
    }

    public class Sudoku_Solution_Validator_Clever
    {
        public static bool ValidateSolution(int[][] board)
        {
            return Enumerable
              .Range(0, 9)
              .SelectMany(i => new[]
              {
                  board[i].Sum(),
                  board.Sum(b => b[i]),
                  board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Sum()
              })
              .All(i => i == 45);
        }
    }
}