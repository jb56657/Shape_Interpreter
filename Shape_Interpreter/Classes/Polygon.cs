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
