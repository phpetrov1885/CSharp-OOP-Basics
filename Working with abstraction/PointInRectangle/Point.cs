using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInRectangle
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Func<string> coords)
        {
            var coordsPoint = coords()
                .Split()
                .Select(int.Parse)
                .ToList();
            X = coordsPoint[0];
            Y = coordsPoint[1];
        }
    }
}
