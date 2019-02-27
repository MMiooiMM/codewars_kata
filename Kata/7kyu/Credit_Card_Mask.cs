namespace Kata._7kyu
{
    //https://www.codewars.com/kata/5412509bd436bd33920011bc
    public static class Credit_Card_Mask
    {
        public static string Maskify(string cc)
        {
            return (cc.Length <= 4) ? cc : cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
        }
    }
}
