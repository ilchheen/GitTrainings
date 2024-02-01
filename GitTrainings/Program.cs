using System;

namespace GitTrainings
{
    internal class Program
    {
        static void Test()
        {
            Console.WriteLine("Test");
            TestMethod(1,2);
        }

        static int TestMethod(int x, int y)
        {
            return x + y;
        }
    }
}
