using Shape_Interpreter.Classes;
using System;
using System.IO;

namespace Shape_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Shape[] shapes =
            {
                new Square(6, new Point(1, 2), 3.14, 1),
                new Square(1, new Point(0, 0), 0, 3)
            };

            FileWriter.writeCalculationsToCSVFile(shapes, "squareTests.csv");
        }
    }
}
