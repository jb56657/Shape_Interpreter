using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape_Interpreter.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter_Test
{
    [TestClass]
    public class FileReaderTests
    {
        [TestMethod]
        public void testReadingCircle()
        {
            Shape circle = new Circle(158, new Point(6.25, 1.4), 18);

            Shape csvCircle = FileReader.readFromCSVFile("circle.csv")[0];

            Assert.AreEqual(circle, csvCircle);
        }

        [TestMethod]
        public void testReadingEllipse()
        {
            Shape ellipse = new Ellipses(16, new Point(22.1, 6.8), 1.05, 1.2, 5.4);

            Shape csvEllipse = FileReader.readFromCSVFile("ellipse.csv")[0];

            Assert.AreEqual(ellipse, csvEllipse);
        }

        [TestMethod]
        public void testReadingTriangle()
        {
            Shape triangle = new Triangle(292, new Point(62.8, 1.9), 4.62, 0.1);

            Shape csvTriangle = FileReader.readFromCSVFile("triangle.csv")[0];

            Assert.AreEqual(triangle, csvTriangle);
        }

        [TestMethod]
        public void testReadingSquare()
        {
            Shape square = new Square(465, new Point(44.4123, 426.606), 3.04899, 51.3439);

            Shape csvSquare = FileReader.readFromCSVFile("square.csv")[0];

            Assert.AreEqual(square, csvSquare);
        }

        [TestMethod]
        public void testReadingPolygon()
        {
            Point[] vertices = new Point[]
            {
                new Point(-14.8, 12),
                new Point(-10.8, 6),
                new Point(-5.8, 12),
                new Point(-10.8, -5)
            };

            Shape polygon = new Polygon(1, vertices);

            Shape csvPolygon = FileReader.readFromCSVFile("polygon.csv")[0];

            Assert.AreEqual(polygon, csvPolygon);
        }
    }
}
