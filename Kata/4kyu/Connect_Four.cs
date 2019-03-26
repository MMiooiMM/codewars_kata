using System.Collections.Generic;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/56882731514ec3ec3d000009
    public class Connect_Four
    {
        static string[,] piecesPositionArray;
        static bool IsWin;
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            piecesPositionArray = new string[7, 6];
            IsWin = false;
            foreach (string piece in piecesPositionList)
            {
                Move(piece);
                if (IsWin)
                    return piece.Split('_')[1];
            }
            return "Draw";
        }
        static void Move(string piece)
        {
            var position = piece.Split('_')[0];
            var player = piece.Split('_')[1];
            int row = -1;
            switch (position)
            {
                case "A":
                    row = 0;
                    break;
                case "B":
                    row = 1;
                    break;
                case "C":
                    row = 2;
                    break;
                case "D":
                    row = 3;
                    break;
                case "E":
                    row = 4;
                    break;
                case "F":
                    row = 5;
                    break;
                case "G":
                    row = 6;
                    break;
            }
            int col = Next(row);
            if (col == -1)
                return;
            piecesPositionArray[row, col] = player;
            Check(row, col);
        }
        static int Next(int row)
        {
            int result = 0;
            for (; result < 6; result++)
            {
                if (piecesPositionArray[row, result] == null)
                    return result;                
            }
            return -1;
        }
        static void Check(int row, int col)
        {
            int count = 0;
            string tmp = "tmp";
            string player = piecesPositionArray[row, col];
            if (col >= 3)
            {
                for (int i = col; i >= 0; i--)
                {
                    if (player == piecesPositionArray[row, i])
                        count++;
                    else
                        count = 0;
                    if (count >= 4)
                    {
                        IsWin = true;
                        return;
                    }
                }
            }
            count = 1;
            tmp = "tmp";
            if (piecesPositionArray[3, col] != null)
            {
                for (int i = 0; i <= 6; i++)
                {
                    if (piecesPositionArray[i, col] == tmp)
                        count++;
                    else
                        count = 1;
                    if (count >= 4)
                    {
                        IsWin = true;
                        return;
                    }
                    tmp = piecesPositionArray[i, col];
                }
            }
            count = 1;
            tmp = "tmp";
            for (int i = row - col, j = 0; i <= 6 && j <= 5; i++, j++)
            {
                if (i < 0)
                    continue;
                if (piecesPositionArray[i, j] == tmp && tmp != null)
                    count++;
                else
                    count = 1;
                if (count >= 4)
                {
                    IsWin = true;
                    return;
                }
                tmp = piecesPositionArray[i, j];
            }
            count = 1;
            tmp = "tmp";
            for (int i = row + col, j = 0; i >= 0 && j <= 5; i--, j++)
            {
                if (i > 6)
                    continue;
                if (piecesPositionArray[i, j] == tmp && tmp != null)
                    count++;
                else
                    count = 1;
                if (count >= 4)
                {
                    IsWin = true;
                    return;
                }
                tmp = piecesPositionArray[i, j];
            }
        }
    }
}
