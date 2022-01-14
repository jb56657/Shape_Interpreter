using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape_Interpreter;
using Shape_Interpreter.Classes;
using System;
using System.IO;

namespace Shape_Interpreter_Test
{
    [TestClass]
    public class ShapeCalculationTests
    {
        private readonly double delta = 0.00001;

        [TestMethod]
        public void SquareTest()
        {
            Shape square = new Square(1, new Point(3.2, 4.5), 3.14, 6.2);

            Assert.AreEqual(38.44, square.calculateArea(), delta);
            Assert.AreEqual(24.8, square.calculatePerimeter(), delta);
            Assert.IsTrue(square.calculateCentroid().approximatelyEqualTo(new Point(3.2, 4.5), delta));
        }

        [TestMethod]
        public void TriangleTest()
        {
            Shape triangle = new Triangle(18, new Point(8.5, 9.9), 2, 6);

            Assert.AreEqual(15.588457268119, triangle.calculateArea(), delta);
            Assert.AreEqual(18, triangle.calculatePerimeter(), delta);
            Assert.IsTrue(triangle.calculateCentroid().approximatelyEqualTo(new Point(8.5, 9.9), delta));
        }

        [TestMethod]
        public void PolygonTest()
        {
            Point[] pointList = new Point[]
            {
                new Point(-1, 0),
                new Point(-1.2, 1),
                new Point(0, 2),
                new Point(1.2, 1),
                new Point(1, 0)
            };
            Shape polygon = new Polygon(6, pointList);

            Assert.AreEqual(3.4, polygon.calculateArea(), delta);
            Assert.AreEqual(7.16371, polygon.calculatePerimeter(), delta);
            Assert.IsTrue(polygon.calculateCentroid().approximatelyEqualTo(new Point(0, 0.8), delta));
        }

        [TestMethod]
        public void PolygonTest2()
        {
            //Test polygon calculations against a square for an easier-to-check test

            Point[] pointList = new Point[]
            {
                new Point(2.9, 5.1),
                new Point(-2.9, 5.1),
                new Point(-2.9, -5.1),
                new Point(2.9, -5.1) 
            };
            Shape polygon = new Polygon(54, pointList);

            Assert.AreEqual(59.16, polygon.calculateArea(), delta);
            Assert.AreEqual(32, polygon.calculatePerimeter(), delta);
            Assert.IsTrue(polygon.calculateCentroid().approximatelyEqualTo(new Point(0, 0), delta));
        }

        [TestMethod]
        public void CircleTest()
        {
            Shape circle = new Circle(8, new Point(15, 7.4), 1.1);

            Assert.AreEqual(3.801327110843, circle.calculateArea(), delta);
            Assert.AreEqual(6.911503837897, circle.calculatePerimeter(), delta);
            Assert.IsTrue(circle.calculateCentroid().approximatelyEqualTo(new Point(15, 7.4), delta));
        }

        [TestMethod]
        public void EllipsesTest()
        {
            Shape ellipses = new Ellipses(1, new Point(0.054, -1.006), -0.314, 9.3, 0.2);

            Assert.AreEqual(5.843362335677, ellipses.calculateArea(), delta);
            Assert.AreEqual(41.328364812784, ellipses.calculatePerimeter(), delta); //Wolfram alpha said 37.2407, but two other sources said 41.3
            Assert.IsTrue(ellipses.calculateCentroid().approximatelyEqualTo(new Point(0.054, -1.006), delta));
        }

        [TestMethod]
        public void EllipsesTest2()
        {
            // Since calculating the perimeter of an ellipses is hard, check the result against an easier-to-calculate circle
            Shape ellipses2 = new Ellipses(3, new Point(0, 0), 0, 1, 1);

            Assert.AreEqual(Math.PI, ellipses2.calculateArea(), delta);
            Assert.AreEqual(Math.PI * 2, ellipses2.calculatePerimeter(), delta);
            Assert.IsTrue(ellipses2.calculateCentroid().approximatelyEqualTo(new Point(0, 0), delta));
        }
    }
}
