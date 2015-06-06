using System;


namespace Geometry.Geometry3D 
{
    public class Point3D
    {
        private static readonly Point3D startIndex = new Point3D(0, 0, 0);
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartIndex
        {
            get
            {
                return startIndex;

            }
        }
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        public override string ToString()
        {
           
            return string.Format("3D point with cordinates: X={0}, Y={1}, Z={2}", this.X, this.Y, this.Z);
        }
    }
}
