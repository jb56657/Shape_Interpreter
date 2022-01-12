﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Interpreter.Classes
{
    interface Shape
    {
        public abstract double calculateArea();

        public abstract double calculatePerimeter();

        public abstract Point calculateCentroid();
    }
}