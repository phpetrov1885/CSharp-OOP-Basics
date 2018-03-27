using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(int topX, int topY, int bottomX, int bottomY)
        {
            TopLeft = new Point(topX, topY);
            BottomRight = new Point(bottomX, bottomY);
        }

        public Rectangle(string coords)
        {
            var coordinates = coords
                .Split()
                .Select(int.Parse)
                .ToList();
            TopLeft = new Point(coordinates[0], coordinates[1]);
            BottomRight = new Point(coordinates[2], coordinates[3]);
        }
        public bool Contains(Point point)
        {
            bool contains =
                point.X >= TopLeft.X && point.X <= BottomRight.X &&
                point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;

            return contains;
        }
    }
}
