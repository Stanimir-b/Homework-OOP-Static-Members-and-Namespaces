using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry.Geometry3D 
{
    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();
        public List<Point3D> Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var points in this.Path)
            {
                result.AppendLine("X=" + points.X + " " + "Y=" + points.Y + " " + "Z=" + points.Z);
            }
            return result.ToString();
        }
     
    }
}
