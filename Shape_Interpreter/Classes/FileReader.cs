using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Shape_Interpreter.Classes
{
    public class FileReader
    {
        public Shape[] readFromCSVFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            List<Shape> shapes = new List<Shape>();
            
            while(!reader.EndOfStream)
            {
                shapes.Add(readShapeFromLine(reader.ReadLine()));
            }
            
            // Release resources that the reader is using.
            reader.Close();

            return shapes.ToArray();
        }

        public Shape readShapeFromLine(string line)
        {
            throw new NotImplementedException();
        }
    }
}
