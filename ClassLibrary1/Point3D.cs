using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Point3D : Point, ICloneable
    {
        public int Z;
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z) : base(x, y) { Z = z; }

        public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";
        public object Clone() => new Point3D(X, Y, Z);
        public override bool Equals(object obj) => obj is Point3D p && X == p.X && Y == p.Y && Z == p.Z;
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);
        public static bool operator ==(Point3D p1, Point3D p2) => p1?.Equals(p2) ?? p2 is null;
        public static bool operator !=(Point3D p1, Point3D p2) => !(p1 == p2);
    }
}
