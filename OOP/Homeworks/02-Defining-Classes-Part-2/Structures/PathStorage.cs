namespace Structures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.

    public static class PathStorage
    {
        private const string FILENAME = @"..\..\points.txt";

        public static void SavePathToFile(Path path)
        {
            StreamWriter writer = new StreamWriter(FILENAME);
            List<Point3D> points = path.PathOfPoints3D;
            using (writer)
            {
                //read path and extract each point coordinates
                foreach (var point in points)
                {
                    int x = point.X;
                    int y = point.Y;
                    int z = point.Z;

                    //write a point into a textfile in the format X Y Z -> 0 0 0
                    writer.Write(string.Format("{0} {1} {2}", x, y, z));
                    writer.Write(Environment.NewLine);
                }
            }
            Console.WriteLine("Path is written!");
        }

        public static Path LoadPathFromFile(string filename)
        {
            Path path = new Path();

            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                //read line by line, split it by spaces - points are in format X Y Z -> 0 0 0
                string line = reader.ReadLine();
                while (line != null)
                {
                    //get points and add them to Path
                    int[] coordinates = line.Split().Select(n => Int32.Parse(n)).ToArray();
                    Point3D point = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                    path.AddPointToPath(point);

                    //read next line
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Reading file successful");
            return path;
        }
    }
}
