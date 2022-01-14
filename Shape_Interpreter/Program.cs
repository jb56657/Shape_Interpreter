using System;
using System.IO;

namespace Shape_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            Console.WriteLine(path);

            // The last "Shape_Interpreter" folder is the base project folder
            int index = 0;
            while (path.IndexOf("Shape_Interpreter", index+1) != -1)
            {
                index = path.IndexOf("Shape_Interpreter", index + 1);
            }
            index = path.IndexOf(@"\", index + 1);
            path = path.Substring(0, index + 1);

            path = Path.Combine(path, @"Resources\Machine Vision Development Engineer Coding Exercise _ ShapeList2.csv");

            Console.WriteLine(path);

            StreamReader reader = new StreamReader(path);

            Console.WriteLine(reader.ReadLine());

            reader.Close();
        }
    }
}
