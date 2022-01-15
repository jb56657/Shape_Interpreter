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
        private double majorRadius; //length of the larger half-axis
        private double minorRadius; //length of the smaller half-axis

        public Ellipses(int id, Point center, double orientation, double radius1, double radius2)
        {
            this.id = id;
            this.center = center;
            this.orientation = orientation;
            if(Math.Abs(radius1) >= Math.Abs(radius2))
            {
                this.majorRadius = radius1;
                this.minorRadius = radius2;
            }
            else //The second radius was actually the larger of the two radii
            {
                this.majorRadius = radius2;
                this.minorRadius = radius1;
            }
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
            return "Ellipse";
        }

        public override bool Equals(object obj)
        {
            if (!typeof(Ellipses).Equals(obj.GetType()))
            {
                return false;
            }
            Ellipses e = (Ellipses)obj;

            return
                (this.id == e.id) &&
                (this.center.Equals(e.center)) &&
                (this.orientation == e.orientation) &&
                (this.majorRadius == e.majorRadius) &&
                (this.minorRadius == e.minorRadius);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
