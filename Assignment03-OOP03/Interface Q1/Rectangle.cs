using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_OOP03.Interface_Q1
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Area => Width * Height;

        public Rectangle(double width,double height) 
        {
            Width = width;
            Height = height;
        }


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle, Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }
}
