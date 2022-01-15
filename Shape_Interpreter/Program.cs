using Shape_Interpreter.Classes;
using System;
using System.IO;

namespace Shape_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "Machine Vision Development Engineer Coding Exercise _ ShapeList2.csv";
            string outputFileName = "Coding_Exercise_Calculation_Results.csv";

            Shape[] shapes = FileReader.readFromCSVFile(inputFileName);

            FileWriter.writeCalculationsToCSVFile(shapes, outputFileName);
        }
    }
}
