namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     Define abstract class  Shape  with only one  abstract  method  CalculateSurface()  and fields  
     width  and  height .
    • Define two new classes  Triangle  and  Rectangle  that implement the  virtual  method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
    • Define class  Square  and suitable constructor so that at initialization  height  must be kept equal to  width  and implement the  CalculateSurface()  method.
    • Write a program that tests the behaviour of the  CalculateSurface()  method for different shapes ( Square ,  Rectangle ,  Triangle ) stored in an array.
 
     */
    class Startup
    {
        static void Main()
        {
            Triangle triangle1 = new Triangle(5.00,6.40);
            Triangle triangle2 = new Triangle(7.50, 8.20);
            
            Rectangle rect1 = new Rectangle(5.25, 12);
            Rectangle rect2 = new Rectangle(7, 8.3);

            Square square1 = new Square(4);
            Square square2 = new Square(5.5);

            Shape[] shapes = new Shape[]{triangle1, triangle2, rect1, rect2, square1, square2 };

            foreach (var sh in shapes)
            {
                Console.WriteLine("Permiter : {0:f2}mm ", sh.CalculateSurface());
                //Console.WriteLine("Permiter : {0:f2}mm - {1}", sh.CalculateSurface(),sh);
            }

            


        }
    }
}
