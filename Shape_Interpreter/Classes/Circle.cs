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
    }
}
