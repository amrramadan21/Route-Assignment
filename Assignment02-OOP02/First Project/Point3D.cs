using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP02.First_Project
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        #region Q1
        public int X { get; set; }
        public int Y { get; set; }
        public double Z { get; set; }

        public Point3D(int x, int y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Q2
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
        #endregion

        #region Q6

        //ICopmparable
        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;

            int cmp = X.CompareTo(other.X);
            if (cmp == 0) cmp = Y.CompareTo(other.Y);
            if (cmp == 0) cmp = Z.CompareTo(other.Z);
            return cmp;
        }

        //ICloneable
        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }




        #endregion

    }
}
