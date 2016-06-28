namespace _01.Shapes
{
    //return the surface of the figure -> height * width for rectangle 
    class Rectangle :Shape
    {
        public Rectangle(double width, double height)
            : base(width, height) {}

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
