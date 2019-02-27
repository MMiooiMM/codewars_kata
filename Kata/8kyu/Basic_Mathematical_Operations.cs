namespace Kata._8kyu
{
    //https://www.codewars.com/kata/57356c55867b9b7a60000bd7
    public static class Basic_Mathematical_Operations
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    return 0;
            }
        }
    }
}
