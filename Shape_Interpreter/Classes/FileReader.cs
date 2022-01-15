using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Shape_Interpreter.Classes
{
    public static class FileReader
    {
        /// <summary>
        /// Read in shapes from a CSV file. This function assumes that the file is located in the Resources folder.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Shape[] readFromCSVFile(string fileName)
        {
            // If the file name does not have the .csv extention, add it.
            if (!fileName.EndsWith(".csv"))
            {
                fileName += ".csv";
            }

            string filePath = getResourcesFolder() + fileName;
            
            // First check that the file exists
            if (!File.Exists(filePath))
            {
                return null;
            }

            StreamReader reader = new StreamReader(filePath);

            List<Shape> shapes = new List<Shape>();
            
            while(!reader.EndOfStream)
            {
                shapes.Add(readShapeFromLine(reader.ReadLine()));
            }
            
            // Release resources that the reader is using.
            reader.Close();

            return shapes.ToArray();
        }

        /// <summary>
        /// If unspecified, refer to the shape CSV file
        /// </summary>
        /// <returns></returns>
        public static Shape[] readFromCSVFile()
        {
            string path = Path.Combine(getResourcesFolder(), @"Resources\Machine Vision Development Engineer Coding Exercise_ShapeList2.csv");
            return readFromCSVFile("");
        }

        /// <summary>
        /// Delegates the shape construction to ShapeFactory based on shape type.
        /// If an invalid shape description is read, returns null.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static Shape readShapeFromLine(string line)
        {
            string[] data = line.Split(',');
            
            // The second string after the split identifies what type of shape is listed.
            // If the line doesn't list the type of shape after the ID, then the format is invalid.
            if(data.Length < 2)
            {
                return null;
            }

            return (data[1]) switch
            {
                "Circle" => ShapeFactory.assembleCircle(data),
                "Ellipse" => ShapeFactory.assembleEllipses(data),
                "Equilateral Triangle" => ShapeFactory.assembleTriangle(data),
                "Square" => ShapeFactory.assembleSquare(data),
                "Polygon" => ShapeFactory.assemblePolygon(data),
                _ => null
            };
        }

        /// <summary>
        /// Returns the Filepath for the Resources folder. This assumes the project is run from the project
        /// folder or a subfolder
        /// </summary>
        /// <returns></returns>
        private static string getResourcesFolder()
        {
            string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            // The "Shape_Interpreter" folder is the base project folder
            int index = path.IndexOf("Shape_Interpreter");
            index = path.IndexOf(@"\", index + 1);
            path = path.Substring(0, index + 1);

            return Path.Combine(path, @"Shape_Interpreter\Resources\");
        }
    }
}
