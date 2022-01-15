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

        public double calculateArea()
        {
            throw new NotImplementedException();
        }

        public Point calculateCentroid()
        {
            throw new NotImplementedException();
        }

        public double calculatePerimeter()
        {
            throw new NotImplementedException();
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
