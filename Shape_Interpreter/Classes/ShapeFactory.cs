using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public static class ShapeFactory
    {
        public static Square assembleSquare(string[] CSVdata)
        {
            throw new NotImplementedException();
        }

        public static Triangle assembleTriangle(string[] CSVdata)
        {
            throw new NotImplementedException();
        }

        public static Polygon assemblePolygon(string[] CSVdata)
        {
            throw new NotImplementedException();
        }

        public static Ellipses assembleEllipses(string[] CSVdata)
        {
            throw new NotImplementedException();
        }

        public static Circle assembleCircle(string[] CSVdata)
        {
            // If there aren't 8 pieces of data for constructing the circle, then the format is incorrect.
            if (CSVdata.Length != 8)
            {
                return null;
            }
            
            // Convert each piece of data to the appropriate data type
            int id; Point center; double radius;
            id = Convert.ToInt32(CSVdata[0]);
            center = new Point(Convert.ToDouble(CSVdata[3]), Convert.ToDouble(CSVdata[5]));
            radius = Convert.ToDouble(CSVdata[7]);

            return new Circle(id, center, radius);
        }
    }
}
