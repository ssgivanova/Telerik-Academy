namespace _01.Shapes
{
    //Define class  Square  and suitable constructor so that at initialization  height  
    //must be kept equal to  width  and implement the  CalculateSurface()  method.

    class Square : Rectangle
    {
        public Square(double width)
            : base(width, width)
        { }

        public override double CalculateSurface()
        {
            return base.CalculateSurface();
        }
    }
}
