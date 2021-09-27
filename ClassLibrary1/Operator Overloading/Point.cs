using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Operator_Overloading
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator + (Point first, Point second)
        {
            return new Point(first.X + second.X, first.Y + second.Y);
        }

        public static bool operator > (Point first, Point second)
        {
            if (first.X > second.X && first.Y > second.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator < (Point first, Point second)
        {
            if (first.X < second.X && first.Y < second.Y)
            {
                return true;
            }
            return false;
        }
    }
}
