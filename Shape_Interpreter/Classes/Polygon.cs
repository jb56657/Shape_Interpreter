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
