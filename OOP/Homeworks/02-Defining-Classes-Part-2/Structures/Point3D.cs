namespace Structures
{
    using System;

    //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    //Implement the ToString() to enable printing a 3D point.

    //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    //Add a static property to return the point O.

    public struct Point3D
    {
        private static readonly Point3D startCoordinateSystem = new Point3D(0, 0, 0);

        private int x;
        private int y;
        private int z;

        public Point3D(int x,int y,int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X 
        {   get { return this.x; } 
            set { this.x = value; } 
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }


        public static Point3D StartCoordinateSystem
        {
            get { return startCoordinateSystem; }
        }

        public override string ToString()
        {
            return String.Format("Point ({0},{1},{2})", this.X, this.Y, this.Z);
        }
    }
}
