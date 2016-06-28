namespace _01.Shapes
{
    //return the surface of the figure ->  height * width/2 for triangle
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
            //this.Width = width;
            //this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
