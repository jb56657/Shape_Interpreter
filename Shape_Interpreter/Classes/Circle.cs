using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Circle : Shape
    {
        private int id;
        private Point center;
        private double radius;

        public Circle(int id, Point center, double radius)
        {
            this.id = id;
            this.center = center;
            this.radius = radius;
        }

        /// <summary>
        /// Area of circle is pi*r^2
        /// </summary>
        /// <returns></returns>
        public double calculateArea()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// The center of the circle is one of the fields
        /// </summary>
        /// <returns></returns>
        public Point calculateCentroid()
        {
            return center;
        }

        /// <summary>
        /// The circumference of a circle is 2*pi*r
        /// </summary>
        /// <returns></returns>
        public double calculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public int getID()
        {
            return id;
        }

        public string getTypeString()
        {
            return "Circle";
        }

        public override bool Equals(object obj)
        {
            if (!typeof(Circle).Equals(obj.GetType()))
            {
                return false;
            }
            Circle c = (Circle)obj;

            return
                (this.id == c.id) &&
                (this.center.Equals(c.center)) &&
                (this.radius == c.radius);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
