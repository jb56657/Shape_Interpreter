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
            Shape square = new Square(new Point(3.2, 4.5), 3.14, 6.2);

            Assert.AreEqual(38.44, square.calculateArea(), delta);
            Assert.AreEqual(24.8, square.calculatePerimeter(), delta);
            Assert.AreEqual(new Point(3.2, 4.5), square.calculateCentroid());
        }
    }
}
