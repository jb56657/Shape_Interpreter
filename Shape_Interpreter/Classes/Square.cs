using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Square : Shape
    {
        private Point center;
        private double orientation;
        private double sideLength;

        public Square(Point center, double orientation, double sideLength)
        {
            this.center = center;
            this.orientation = orientation;
            this.sideLength = sideLength;
        }

        public double calculateArea()
        {
            return sideLength * sideLength;
        }

        public double calculatePerimeter()
        {
            return sideLength * 4;
        }

        public Point calculateCentroid()
        {
            return center;
        }
    }
}
