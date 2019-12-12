using System;

namespace _5lesson
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(TestPrimalNumber(1));
            Console.WriteLine(TestPrimalNumber(7));
            Console.WriteLine(TestPrimalNumber(-1));
            Console.WriteLine(TestPrimalNumber(6));
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
    }
}
