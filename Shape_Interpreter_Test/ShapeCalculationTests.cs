using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape_Interpreter;
using Shape_Interpreter.Classes;

namespace Shape_Interpreter_Test
{
    [TestClass]
    public class ShapeCalculationTests
    {
        private readonly double delta = 0.0000000001;

        [TestMethod]
        public void SquareTest()
        {
            Shape square = new Square(1, new Point(3.2, 4.5), 3.14, 6.2);

            Assert.AreEqual(38.44, square.calculateArea(), delta);
            Assert.AreEqual(24.8, square.calculatePerimeter(), delta);
            Assert.AreEqual(new Point(3.2, 4.5), square.calculateCentroid());
        }

        [TestMethod]
        public void TriangleTest()
        {
            Shape triangle = new Triangle(18, new Point(8.5, 9.9), 2, 6);

            Assert.AreEqual(15.588457268119, triangle.calculateArea(), delta);
            Assert.AreEqual(18, triangle.calculatePerimeter(), delta);
            Assert.AreEqual(new Point(8.5, 9.9), triangle.calculateCentroid());
        }

        [TestMethod]
        public void PolygonTest()
        {
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
            Assert.AreEqual(new Point(0, 0), polygon.calculateCentroid());
        }

        [TestMethod]
        public void CircleTest()
        {
            Shape circle = new Circle(8, new Point(15, 7.4), 1.1);

            Assert.AreEqual(3.801327110843, circle.calculateArea(), delta);
            Assert.AreEqual(6.911503837897, circle.calculatePerimeter(), delta);
            Assert.AreEqual(new Point(15, 7.4), circle.calculateCentroid());
        }

        public void EllipsesTest()
        {
            Shape ellipses = new Ellipses(1, new Point(0.054, -1.006), -0.314, 9.3, 0.2);

            Assert.AreEqual(5.843362335677, ellipses.calculateArea(), delta);
            Assert.AreEqual(41.328364812784, ellipses.calculatePerimeter(), delta); //Wolfram alpha said 37.2407, but two other sources said 41.3
            Assert.AreEqual(new Point(0.054, -1.006), ellipses.calculateCentroid());
        }
    }
}
