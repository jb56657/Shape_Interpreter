using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shape_Interpreter.Classes
{
    public static class FileWriter
    {
        public static void writeCalculationsToCSVFile(Shape[] shapes, string fileName)
        {
            string path = getOutputFolder() + fileName;
            
            // If the file already exists, delete the old one.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StreamWriter writer = new StreamWriter(path);

            foreach (Shape shape in shapes)
            {
                writer.WriteLine(assembleOutputString(shape));
            }

            writer.Close();
        }

        public static string assembleOutputString(Shape shape)
        {
            // Convert all the information to strings to be assembled together
            string id = Convert.ToString(shape.getID());
            string area = Convert.ToString(shape.calculateArea());
            string circumference = Convert.ToString(shape.calculatePerimeter());

            // We need the x and y values of the centroid separately
            Point center = shape.calculateCentroid();
            string centerX = Convert.ToString(center.getX());
            string centerY = Convert.ToString(center.getY());

            // Assemble all of the information into one string
            StringBuilder output = new StringBuilder();
            output.Append(id + ",");
            output.Append(shape.getTypeString() + ",");
            output.Append("Area," + area + ",");
            output.Append("Perimeter," + circumference + ",");
            output.Append("CenterX," + centerX + ",");
            output.Append("CenterY," + centerY);

            return output.ToString();
        }

        private static string getOutputFolder()
        {
            string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            // The "Shape_Interpreter" folder is the base project folder
            int index = path.IndexOf("Shape_Interpreter");
            index = path.IndexOf(@"\", index + 1);
            path = path.Substring(0, index + 1);

            return Path.Combine(path, @"Shape_Interpreter\Output\");
        }
    }
}
