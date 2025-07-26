using Assignment_03_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Class_Q1
{
    public class Rectangle : IRectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle\nWidth: {Width}\nHeight: {Height}\nArea: {Area:F2}\n");
        }
    }

}
