namespace Structures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //Create a class Path to hold a sequence of points in the 3D space.

    public class Path
    {
        private List<Point3D> pathOfPoints3D;

        public Path()
        {
            pathOfPoints3D = new List<Point3D>();
        }

        public List<Point3D> PathOfPoints3D
        {
            get { return this.pathOfPoints3D; }
        }

        public void AddPointToPath(Point3D point)
        {
            this.pathOfPoints3D.Add(point);
        }

        public void DeletePointFromPath(Point3D point)
        {
            this.pathOfPoints3D.Remove(point);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Points in the path :\n");
            foreach (Point3D point in this.pathOfPoints3D)
            {
                sb.Append(point.ToString());
                sb.Append(" ");
            }

            return sb.ToString();
        }

    }
}
