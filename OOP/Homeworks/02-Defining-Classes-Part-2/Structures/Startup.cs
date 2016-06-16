namespace Structures
{
    using System;

    class Startup
    {
        static void Main()
        {
            //create 3 points
            Point3D p1 = new Point3D(5, 6, 8);
            Point3D p2 = new Point3D(10, 12, 4);
            Point3D p3 = new Point3D(3, 16, 7);

            //calculate distance between p1,p2 and p3
            double distanceP12 = CalculateDistance.CalculateDistanceBetweenTwoPoints(p1, p2);
            Console.WriteLine(distanceP12);


            //create path 
            Path path = new Path();
            path.AddPointToPath(p1);
            path.AddPointToPath(p2);
            path.AddPointToPath(p3);

            Console.WriteLine(path);

            //save path to file
            PathStorage.SavePathToFile(path);

            //load path from file
            Path pathFromFile = PathStorage.LoadPathFromFile(@"..\..\points.txt");
            Console.WriteLine(pathFromFile);

            
        }
    }
}
