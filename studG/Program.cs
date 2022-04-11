using System;

namespace studG
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSpD = 0;
            for (int x = 520001; countOfSpD < 5; x++) 
            {
                int sumOfD = 0;
                int theFirstD = 0;
                for(int d = x - 1; d > 1; d--)
                {
                    if (x % d == 0)
                    {
                        if (theFirstD == 0) theFirstD = d;
                        sumOfD += d;
                    }
                }
                if (isPal(sumOfD) == true)
                {
                    Console.WriteLine( x + "   " + theFirstD);
                    countOfSpD++;
                }
            }
        }
        static bool isPal(int x)
        {
            if (x == 0) return false;
            char[] XinChar = x.ToString().ToCharArray();
            if (XinChar.Length % 2 == 0)
            {
                for(int a = 0; a <= XinChar.Length / 2; a++)
                {
                    if (XinChar[a].ToString().Equals(XinChar[XinChar.Length - 1 - a].ToString())) continue;
                    else return false;
                }
                return true;
            }
            else
            {
                for (int a = 0; a <= Math.Ceiling((XinChar.Length / 2d)); a++)
                {
                    if (XinChar[a].ToString().Equals(XinChar[XinChar.Length - 1 - a].ToString())) continue;
                    else return false;
                }
                return true;
            }
        }
    }
}
