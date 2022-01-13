﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public class Triangle : Shape
    {
        private int id;
        private Point center;
        private double orientation; //orientation of one of the sides in radians
        private double sideLength;

        public Triangle(int id, Point center, double orientation, double sideLength)
        {
            this.id = id;
            this.center = center;
            this.orientation = orientation;
            this.sideLength = sideLength;
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