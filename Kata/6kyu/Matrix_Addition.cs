namespace Kata._6kyu
{
    //https://www.codewars.com/kata/526233aefd4764272800036f
    public class Matrix_Addition
    {
        public static int[][] MatrixAddition(int[][] a, int[][] b)
        {
            int[][] r = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                r[i] = new int[a[i].Length];
                for (int j = 0; j < a[i].Length; j++)
                {
                    r[i][j] = a[i][j] + b[i][j];
                }
            }
            return r;
        }
    }
}