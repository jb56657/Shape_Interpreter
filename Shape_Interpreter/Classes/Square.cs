using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Square : Shape
    {
        private int id;
        private Point center;
        private double orientation;  //orientation of one side in radians.
        private double sideLength;

        public Square(int id, Point center, double orientation, double sideLength)
        {
            this.id = id;
            this.center = center;
            this.orientation = orientation;
            this.sideLength = sideLength;
        }

        /// <summary>
        /// Area of the square is calculated by multiplying the width and the height
        /// </summary>
        /// <returns>Area of the square</returns>
        public double calculateArea()
        {
            return sideLength * sideLength;
        }

        /// <summary>
        /// The length of the perimeter is the sum of the length of all four sides.
        /// </summary>
        /// <returns>Perimeter of the square</returns>
        public double calculatePerimeter()
        {
            return sideLength * 4;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Center point of the Square</returns>
        public Point calculateCentroid()
        {
            return center;
        }

        public int getID()
        {
            return id;
        }
    }
}
