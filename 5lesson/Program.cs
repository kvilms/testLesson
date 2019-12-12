using System;

namespace _5lesson
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
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

=======
            Console.WriteLine(TestPrimalNumber(1));
            Console.WriteLine(TestPrimalNumber(7));
            Console.WriteLine(TestPrimalNumber(-1));
            Console.WriteLine(TestPrimalNumber(6));
            Console.WriteLine(D20());
        }
        static bool TestPrimalNumber(int testNumber)
        {

            for (int i = 2; i < testNumber; i++)
            {
                if (testNumber % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static int D20()
        {
            Random random = new Random();
            return random.Next(1, 21) +1 ;
>>>>>>> master
        }

    }
}
