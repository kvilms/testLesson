using System;

namespace _5lesson
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetMaxNumber(1, 2, 3));
            Console.WriteLine(GetMaxNumber(2, 2, 3));
            Console.WriteLine(GetMaxNumber(1, 5, 6));
        }

        static int GetMaxNumber(int nr1, int nr2, int nr3)
        {
            if ( nr1 > nr2 && nr1 > nr3 )
            {
                return nr1;
            }
            else if (nr2 > nr3)
            {
                return nr2;
            }
            return nr3;

        }

    }
}
