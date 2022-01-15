using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public static class ShapeFactory
    {
        public static Square assembleSquare(string[] CSVdata)
        {
            // A square will split into 10 segments if formatted correctly
            if (CSVdata.Length != 10)
            {
                return null;
            }

            // Convert each piece of data to the appropriate data type
            int id = Convert.ToInt32(CSVdata[0]);
            Point center = new Point(Convert.ToDouble(CSVdata[3]), Convert.ToDouble(CSVdata[5]));
            double sidelength = Convert.ToDouble(CSVdata[7]);
            double orientation = Convert.ToDouble(CSVdata[9]);

            return new Square(id, center, orientation, sidelength);
        }

        public static Triangle assembleTriangle(string[] CSVdata)
        {
            // A triangle will split into 10 segments if formatted correctly
            if (CSVdata.Length != 10)
            {
                return null;
            }

            // Convert each piece of data to the appropriate data type
            int id = Convert.ToInt32(CSVdata[0]);
            Point center = new Point(Convert.ToDouble(CSVdata[3]), Convert.ToDouble(CSVdata[5]));
            double sideLength = Convert.ToDouble(CSVdata[7]);
            double orientation = Convert.ToDouble(CSVdata[9]);

            return new Triangle(id, center, orientation, sideLength);
        }

        public static Polygon assemblePolygon(string[] CSVdata)
        {
            // A polygon will have an id, the "Polygon" label, and 4 strings for each data point (if formatted correctly)
            if (((CSVdata.Length - 2) % 4) != 0)
            {
                return null;
            }
            // A polygon also needs at least 3 points to be valid.
            else if (CSVdata.Length < 14)
            {
                return null;
            }

            // translate each vertex into a point
            List<Point> points = new List<Point>();
            for (int i = 2; i+3 < CSVdata.Length; i+=4)
            {
                double x = Convert.ToDouble(CSVdata[i + 1]);
                double y = Convert.ToDouble(CSVdata[i + 3]);
                points.Add(new Point(x, y));
            }

            int id = Convert.ToInt32(CSVdata[0]);

            return new Polygon(id, points.ToArray());
        }

        public static Ellipses assembleEllipses(string[] CSVdata)
        {
            // An ellipse will be split into 12 strings if formatted correctly.
            if (CSVdata.Length != 12)
            {
                return null;
            }

            // Convert each piece of data to the appropriate data type
            int id = Convert.ToInt32(CSVdata[0]);
            Point center = new Point(Convert.ToDouble(CSVdata[3]), Convert.ToDouble(CSVdata[5]));
            double orientation = Convert.ToDouble(CSVdata[11]);
            double radius1 = Convert.ToDouble(CSVdata[7]);
            double radius2 = Convert.ToDouble(CSVdata[9]);

            return new Ellipses(id, center, orientation, radius1, radius2);
        }

        public static Circle assembleCircle(string[] CSVdata)
        {
            // If there aren't 8 pieces of data for constructing the circle, then the format is incorrect.
            if (CSVdata.Length != 8)
            {
                return null;
            }
            
            // Convert each piece of data to the appropriate data type
            int id = Convert.ToInt32(CSVdata[0]);
            Point center = new Point(Convert.ToDouble(CSVdata[3]), Convert.ToDouble(CSVdata[5]));
            double radius = Convert.ToDouble(CSVdata[7]);

            return new Circle(id, center, radius);
        }
    }
}
