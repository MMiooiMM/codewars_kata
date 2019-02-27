namespace Kata._4kyu
{
    //https://www.codewars.com/kata/52423db9add6f6fc39000354
    public static class Conways_Game_of_Life_Unlimited_Edition
    {
        public static int[,] GetGeneration(int[,] cells, int generation)
        {
            int g = generation;
            int[,] result = cells;
            while (g-- > 0)
            {
                result = Next(result);
            }
            return (result);
        }
        static int[,] Next(int[,] cells)
        {
            int maxRow = cells.GetLength(0) + 2;
            int maxCol = cells.GetLength(1) + 2;
            int[,] Next = new int[maxRow, maxCol];
            int[,] dummy = new int[maxRow, maxCol];
            for (int i = 0; i < maxRow - 2; i++)
            {
                for (int j = 0; j < maxCol - 2; j++)
                {
                    dummy[i + 1, j + 1] = cells[i, j];
                }
            }
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    int lives = neighbours(dummy, i, j);
                    switch (lives)
                    {
                        case 3:
                            Next[i, j] = 1;
                            break;
                        case 2:
                            Next[i, j] = dummy[i, j];
                            break;
                        default:
                            Next[i, j] = 0;
                            break;
                    }
                }
            }
            while (Next != Check(Next))
            {
                Next = Check(Next);
            }
            return Next;
        }
        public static int neighbours(int[,] cells, int row, int col)
        {
            int lives = 0;
            int maxrow = cells.GetLength(0) - 1;
            int maxcol = cells.GetLength(1) - 1;
            lives += (row > 0) ? cells[row - 1, col] : 0;
            lives += (row > 0 && col != maxcol) ? cells[row - 1, col + 1] : 0;
            lives += (col > 0) ? cells[row, col - 1] : 0;
            lives += (col > 0 && row != maxrow) ? cells[row + 1, col - 1] : 0;
            lives += (row > 0 && col > 0) ? cells[row - 1, col - 1] : 0;
            lives += (col != maxcol) ? cells[row, col + 1] : 0;
            lives += (row != maxrow) ? cells[row + 1, col] : 0;
            lives += (row != maxrow && col != maxcol) ? cells[row + 1, col + 1] : 0;
            return lives;
        }
        public static int[,] Check(int[,] cells)
        {
            int count = 0;
            for (int i = 0; i < cells.GetLength(1); i++)
            {
                count += cells[0, i];
            }
            if (count == 0)
            {
                int[,] Newcells = new int[cells.GetLength(0) - 1, cells.GetLength(1)];
                for (int i = 0; i < Newcells.GetLength(0); i++)
                {
                    for (int j = 0; j < Newcells.GetLength(1); j++)
                    {
                        Newcells[i, j] = cells[i + 1, j];
                    }
                }
                cells = Newcells;
            }
            count = 0;
            for (int i = 0; i < cells.GetLength(1); i++)
            {
                count += cells[cells.GetLength(0) - 1, i];
            }
            if (count == 0)
            {
                int[,] Newcells = new int[cells.GetLength(0) - 1, cells.GetLength(1)];
                for (int i = 0; i < Newcells.GetLength(0); i++)
                {
                    for (int j = 0; j < Newcells.GetLength(1); j++)
                    {
                        Newcells[i, j] = cells[i, j];
                    }
                }
                cells = Newcells;
            }
            count = 0;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                count += cells[i, 0];
            }
            if (count == 0)
            {
                int[,] Newcells = new int[cells.GetLength(0), cells.GetLength(1) - 1];
                for (int i = 0; i < Newcells.GetLength(0); i++)
                {
                    for (int j = 0; j < Newcells.GetLength(1); j++)
                    {
                        Newcells[i, j] = cells[i, j + 1];
                    }
                }
                cells = Newcells;
            }
            count = 0;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                count += cells[i, cells.GetLength(1) - 1];
            }
            if (count == 0)
            {
                int[,] Newcells = new int[cells.GetLength(0), cells.GetLength(1) - 1];
                for (int i = 0; i < Newcells.GetLength(0); i++)
                {
                    for (int j = 0; j < Newcells.GetLength(1); j++)
                    {
                        Newcells[i, j] = cells[i, j];
                    }
                }
                cells = Newcells;
            }
            return cells;
        }
    }
}
