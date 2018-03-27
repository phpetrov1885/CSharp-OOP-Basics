using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rhombusSize = int.Parse(Console.ReadLine());

            for (int rowSize = 1; rowSize < rhombusSize; rowSize++)
            {
                PrintRow(rhombusSize,rowSize);
            }
            for (int rowSize = rhombusSize-1; rowSize > 0; rowSize--)
            {
                PrintRow(rhombusSize, rowSize);
            }

        }

        private static void PrintRow(int rhombusSize, int rowSize)
        {
            for (int j = 1; j < rhombusSize-rowSize; j++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < rowSize; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
