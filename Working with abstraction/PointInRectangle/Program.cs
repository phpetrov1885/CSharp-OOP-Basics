using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            var rectangle = new Rectangle(Console.ReadLine());
            var pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                var currentPoints = new Point(Console.ReadLine);
                var containsCoord = rectangle.Contains(currentPoints);

                Console.WriteLine(containsCoord);
            }
        }
    }
}
