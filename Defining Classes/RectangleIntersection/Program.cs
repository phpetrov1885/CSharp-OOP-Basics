using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        int[] inputNumbs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rectanglesTotal = inputNumbs[0];
        int checks = inputNumbs[1];

        SplitAndAddRectangle(rectangles, rectanglesTotal);

        ReadRectanglesIdAndCheckForIntersection(checks, rectangles);
    }

    private static void ReadRectanglesIdAndCheckForIntersection(int checks, List<Rectangle> rectangles)
    {
        for (int i = 0; i < checks; i++)
        {
            string[] rectanglesNames = Console.ReadLine().Split();
            string firstRectangleName = rectanglesNames[0];
            string secondRectangleName = rectanglesNames[1];

            if (rectangles.Any(r => r.Id == firstRectangleName)
                && rectangles.Any(r => r.Id == secondRectangleName))
            {
                Rectangle firstRectangle = rectangles.Where(r => r.Id == firstRectangleName).First();
                Rectangle secondRectangle = rectangles.Where(r => r.Id == secondRectangleName).First();
                if (firstRectangle.IsIntersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }

    private static void SplitAndAddRectangle(List<Rectangle> rectangles, int rectanglesTotal)
    {
        for (int i = 0; i < rectanglesTotal; i++)
        {
            string[] rectangleArgs = Console.ReadLine().Split();

            string rectangleName = rectangleArgs[0];
            int rectangleWidht = int.Parse(rectangleArgs[1]);
            int rectangleHeight = int.Parse(rectangleArgs[2]);
            int topLeftX = int.Parse(rectangleArgs[3]);
            int topLeftY = int.Parse(rectangleArgs[4]);

            Rectangle rectangle = new Rectangle(rectangleName, rectangleWidht, rectangleHeight,
                topLeftX, topLeftY);

            rectangles.Add(rectangle);
        }
    }
}

