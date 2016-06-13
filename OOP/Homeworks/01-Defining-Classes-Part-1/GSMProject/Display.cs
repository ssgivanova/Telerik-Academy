namespace GSMProject
{
    using System;

    //display characteristics (size and number of colors).

    public class Display
    {
        public Display(int width, int height, double size)
        {
            this.ResolutionWidth = width;
            this.ResolutionHeight = height;
            this.Size = size;
        }

        public Display(int width, int height, double size, int nbrColors) : this(width,height,size)
        {
            this.NumberOfColors = NumberOfColors;
        }

        public override string ToString()
        {
            return String.Format("Display : {0}inches, {1}x{2} pxls", this.Size, this.ResolutionWidth, this.ResolutionHeight);
        }

        public int ResolutionWidth { get; private set; }

        public int ResolutionHeight { get; private set; }

        public double Size { get; set; }

        public int NumberOfColors { get; private set; }
    }
}
