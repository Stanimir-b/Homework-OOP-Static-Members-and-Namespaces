using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point;

class DistanceCalculator
{
    public static double CalcDistance(Point3D a, Point3D b)
    {
        return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2) + Math.Pow((a.Z - b.Z), 2));
    }
}

