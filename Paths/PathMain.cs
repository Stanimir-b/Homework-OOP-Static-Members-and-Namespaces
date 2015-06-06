using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point;

class PathMain
{
    static void Main()
    {
        List<Point3D> listOfPoints = new List<Point3D>();
        listOfPoints.Add(new Point3D(3, 5, 9));
        listOfPoints.Add(new Point3D(-5, 5, 9.5));
        listOfPoints.Add(new Point3D(3, -4, 8));
        Path3D p = new Path3D(listOfPoints);
        string fileLocation = "../../Path.txt";
        Storaje.SavePath(fileLocation,p);
        Path3D patchFromFile = Storaje.LoadPath(fileLocation);
        Console.WriteLine(patchFromFile);
    }
}

