using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Ellipses : Shape
    {
        private int id;
        private Point center;
        private double orientation; //Orientation of the larger axis in radians
        private double radius1; //length of the larger half-axis
        private double radius2; //length of the smaller half-axis

        public Ellipses(int id, Point center, double orientation, double radius1, double radius2)
        {
            this.id = id;
            this.center = center;
            this.orientation = orientation;
            this.radius1 = radius1;
            this.radius2 = radius2;
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
