using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_OOP03.Interface_Q1
{
    interface IShape
    {
        public double Area { get;}

        public void DisplayShapeInfo();
    }

    interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
