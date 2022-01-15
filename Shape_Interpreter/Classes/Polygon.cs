using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Polygon : Shape
    {
        private int id;
        private Point[] vertices;

        public Polygon(int id, Point[] vertices)
        {
            this.id = id;
            this.vertices = vertices;
        }

        /// <summary>
        /// Calculate the area of the polygon using the shoelace formula.
        /// The result of the formula can be negative if the polygon is
        /// negatively oriented, so we will take the absolute value of the 
        /// result.
        /// Formula taken from https://en.wikipedia.org/wiki/Shoelace_formula
        /// </summary>
        /// <returns>Area of the polygon</returns>
        public double calculateArea()
        {
            double sum = 0;

            for (int i = 0; i < vertices.Length; i++)
            {
                // Use j as the "wrap-around" i+1 index
                int j = i + 1;
                if (j >= vertices.Length)
                {
                    j = 0;
                }

                sum += (vertices[i].getX() * vertices[j].getY())
                    - (vertices[j].getX() * vertices[i].getY());
            }

            return Math.Abs(sum / 2);
        }

        /// <summary>
        /// The centroid of the polygon can be determined by taking the 
        /// average of each point's x and y values
        /// </summary>
        /// <returns></returns>
        public Point calculateCentroid()
        {
            double xSum = 0;
            double ySum = 0;

            foreach(Point p in vertices)
            {
                xSum += p.getX();
                ySum += p.getY();
            }

            double xAverage = xSum / vertices.Length;
            double yAverage = ySum / vertices.Length;

            return new Point(xAverage, yAverage);
        }

        /// <summary>
        /// Perimeter is calculated by adding the lengths of each side.
        /// </summary>
        /// <returns></returns>
        public double calculatePerimeter()
        {
            double sum = 0;

            for (int i = 0; i < vertices.Length; i++)
            {
                // Use j as the "wrap-around" i+1 index
                int j = i + 1;
                if (j >= vertices.Length)
                {
                    j = 0;
                }

                // find the difference between the x and y values.
                double deltaX = vertices[i].getX() - vertices[j].getX();
                double deltaY = vertices[i].getY() - vertices[j].getY();

                sum += Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            }

            return sum;
        }

        public int getID()
        {
            return id;
        }

        public string getTypeString()
        {
            return "Polygon";
        }

        public override bool Equals(object obj)
        {
            if (!typeof(Polygon).Equals(obj.GetType()))
            {
                return false;
            }
            Polygon p = (Polygon)obj;

            // if the polygons don't have the same number of points, then they are not equal
            if (this.vertices.Length != p.vertices.Length)
            {
                return false;
            }
            
            // Check that each vertex is equal
            for (int i=0; i<vertices.Length; i++)
            {
                if (!this.vertices[i].Equals(p.vertices[i]))
                {
                    return false;
                }
            }

            // if the id of both polygons don't match, then they are not equal. Otherwise they are equal.
            return (this.id == p.id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
