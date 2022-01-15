using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Triangle : Shape
    {
        private int id;
        private Point center;
        private double orientation; //orientation of one of the sides in radians
        private double sideLength;

        public Triangle(int id, Point center, double orientation, double sideLength)
        {
            this.id = id;
            this.center = center;
            this.orientation = orientation;
            this.sideLength = sideLength;
        }

        /// <summary>
        /// The area of a triangle is height * baseLength / 2
        /// </summary>
        /// <returns></returns>
        public double calculateArea()
        {
            double height = Math.Sqrt(Math.Pow(sideLength, 2) - Math.Pow(sideLength / 2, 2));

            return height * sideLength / 2;
        }

        /// <summary>
        /// The center point is a provided parameter when constructing a triangle.
        /// </summary>
        /// <returns></returns>
        public Point calculateCentroid()
        {
            return center;
        }

        /// <summary>
        /// The perimeter of a triangle is just 3 times the side length.
        /// </summary>
        /// <returns></returns>
        public double calculatePerimeter()
        {
            return sideLength * 3;
        }

        public int getID()
        {
            return id;
        }

        public string getTypeString()
        {
            return "Equilateral Triangle";
        }

        public override bool Equals(object obj)
        {
            if (!typeof(Triangle).Equals(obj.GetType()))
            {
                return false;
            }
            Triangle t = (Triangle)obj;

            return
                (this.id == t.id) &&
                (this.center.Equals(t.center)) &&
                (this.orientation == t.orientation) &&
                (this.sideLength == t.sideLength);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
