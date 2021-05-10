using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gk_zad2
{
    public class MyPoint
    {
        public int X { set { Point.X = value; } get { return Point.X; } }
        public int Y { set { Point.Y = value; } get { return Point.Y; } }
        public Point Point;
        public Color Color { set; get; }
        public MyPoint(int x,int y)
        {
            Point = new Point(x, y);
        }
        public bool IsInside(Point point)
        {
            double w = 4;
            if (point.X > this.X + w) return false;
            if (point.X < this.X - w) return false;
            if (point.Y > this.Y + w) return false;
            if (point.Y < this.Y - w) return false;
            return true;
        }
    }
}
