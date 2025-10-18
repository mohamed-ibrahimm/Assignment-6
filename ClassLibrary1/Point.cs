using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Point : IComparable<Point>
    {
        public int X, Y;
        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"Point Coordinates: ({X}, {Y})";

        public int CompareTo(Point other) => X != other.X ? X.CompareTo(other.X) : Y.CompareTo(other.Y);
        public override bool Equals(object obj) => obj is Point p && X == p.X && Y == p.Y;

        public override int GetHashCode() => HashCode.Combine(X, Y);
        public static bool operator ==(Point p1, Point p2) => p1?.Equals(p2) ?? p2 is null;
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);


    }
}
