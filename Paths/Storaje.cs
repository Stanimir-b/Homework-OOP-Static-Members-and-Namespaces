using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Point;



public static class Storaje
{
    private const string pointMatch = @"([-+]?[0-9]*\.?[0-9])";
    
    public static void SavePath(string fileLocation, Path3D result)
    {
        File.WriteAllText(fileLocation, result.ToString());
    }
    public static Path3D LoadPath(string filelocation)
    {
        string input = File.ReadAllText(filelocation);
        var pointsOutputMathc = new List<Point3D>();
        MatchCollection maches = Regex.Matches(input, pointMatch);
        int count = 0;
        double x=0;
        double y=0;
        double z=0;
        
            foreach (Match match in maches)
            {
                if (count==0)
                {
                     x = double.Parse(match.Groups[1].Value);
                     count++;
                }
                else if(count==1)
                {
                    y = double.Parse(match.Groups[1].Value);
                    count++;
                }
                else if (count==2)
                {
                     z = double.Parse(match.Groups[1].Value);
                     count++;
                }
                if (count==3)
                {
                    pointsOutputMathc.Add(new Point3D(x, y, z));
                    count = 0;
                }
            
        }
        
        Path3D pointsParse = new Path3D(pointsOutputMathc);
        return pointsParse;
    }
}
