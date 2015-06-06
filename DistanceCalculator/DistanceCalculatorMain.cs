using System;
using Point;

class DistanceCalculatorMain
{
    static void Main()
    {
        Point3D a = new Point3D(-4, 5, -3);
        Point3D b = new Point3D(12, 9, -3);
        Console.WriteLine(DistanceCalculator.CalcDistance(a, b));
    }
}

