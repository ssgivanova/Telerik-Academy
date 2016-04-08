using System;
using System.Threading;
using System.Globalization;

//Write a program that reads a pair of coordinates x and y and uses an expression to checks for 
//given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  
//R(top=1, left=-1, width=6, height=2)

//input : x and y

//output : 
//•Print inside circle if the point is inside the circle and outside circle if it's outside. 
//Then print a single whitespace followed by inside rectangle if the point is inside the rectangle 
//and outside rectangle otherwise

class PointInCircleAndRectangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float xc = 1.0f;
            float yc = 1.0f;
            float radius = 1.5f;

            float width = 6.0f;
            float height = 2.0f;

            float rectTopLeftX = 1.0f;
            float rectTopLeftY = -1.0f;
            float rectBottomRightX = rectTopLeftX + width;
            float rectBottomRightY = rectTopLeftY - height;

            //Console.WriteLine("top : {0},{1}",rectTopLeftX,rectTopLeftY);
            //Console.WriteLine("bottom : {0},{1}",rectBottomRightX,rectBottomRightY);

            bool insideCircle = false;
            bool insideRectangle = false;

            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            //check if the point is inside the rectangle
            if (x >= rectTopLeftX && x <= rectBottomRightX && y <= rectTopLeftY && y >= rectBottomRightY)
            {
                insideRectangle = true;
            }
            //check if the point is inside the circle
            float dx = Math.Abs(x-xc);
            float dy = Math.Abs(y-yc);
            double distance = Math.Sqrt((dx * dx) + (dy * dy));
            insideCircle = distance <= radius ? true : false;

            if (insideCircle)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if (insideRectangle)
            {
                Console.Write("inside rectangle ");
            }
            else
            {
                Console.Write("outside rectangle ");
            }


        }
}

