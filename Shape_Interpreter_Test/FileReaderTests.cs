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
    }
}
