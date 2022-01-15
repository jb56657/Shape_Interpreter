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

        /// <summary>
        /// The Area of an ellipse is pi*r1*r2
        /// </summary>
        /// <returns>area of the ellipse</returns>
        public double calculateArea()
        {
            return Math.PI * majorRadius * minorRadius;
        }

        /// <summary>
        /// The center of the ellipse is given
        /// </summary>
        /// <returns>central point of the shape</returns>
        public Point calculateCentroid()
        {
            return center;
        }

        /// <summary>
        /// Approximate the perimeter using Ramanujan's approximation
        /// Formula used is Approximation 3 from https://www.mathsisfun.com/geometry/ellipse-perimeter.html
        /// </summary>
        /// <returns>approximation of the perimeter of the ellipse</returns>
        public double calculatePerimeter()
        {
            double h = Math.Pow(majorRadius - minorRadius, 2) / Math.Pow(majorRadius + minorRadius, 2);

            double seriesApproximation = 1 + (3 * h) / (10 + Math.Sqrt(4 - (3 * h)));

            return Math.PI * (majorRadius + minorRadius) * seriesApproximation;
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
