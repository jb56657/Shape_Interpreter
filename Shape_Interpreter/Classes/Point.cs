using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        /// <summary>
        /// Allows for two Point objects to be compared while allowing for a margin of error.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public bool approximatelyEqualTo(Point p, double delta)
        {
            // ensure that both x and y values are equal within a margin of error.
            double xDifference = Math.Abs(x - p.x);
            double yDifference = Math.Abs(y - p.y);

            if (xDifference > delta) { return false; }
            else if (yDifference > delta) { return false; }

            return true;
        }

        /// <summary>
        /// If two points are equal, the x and y values will be equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // ensure that obj is a Point object
            if (!typeof(Point).Equals(obj.GetType()))
            {
                return false;
            }
            Point p = (Point)obj;

            if (this.x == p.x && this.y == p.y) { return true; }
            else { return false; };
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
