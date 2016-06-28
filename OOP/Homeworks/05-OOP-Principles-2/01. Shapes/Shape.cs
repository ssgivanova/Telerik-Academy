namespace _01.Shapes
{
    using System;

    abstract class Shape
    {
        //Define abstract class  Shape  with only one  abstract  method  CalculateSurface()  
        //and fields  width  and  height .

        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0) throw new ArgumentException("Width must be positive!");
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0) throw new ArgumentException("Height must be positive!");
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return String.Format("{0}({1},{2})", this.GetType().Name, this.Width, this.Height);

        }
    }
}
