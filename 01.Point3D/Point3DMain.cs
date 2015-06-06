using System;

namespace Point
{
     class Point3DMain
    {
        static void Main()
        {

            Point3D p = new Point3D(3, 4, 5);
            Point3D s = Point3D.StartIndex;

            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}
