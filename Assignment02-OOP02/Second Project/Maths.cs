using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP02.Second_Project
{
    internal class Maths
    {
        int A{  get; set; }
        int B{ get; set; }

        //public Maths(int a,int b) 
        //{
        //    A = a;
        //    B = b;

        //}

        public int Add(int a ,int b) 
        {
            return a + b;
            
        }

        public int Subtract(int a, int b)
        {
            return a - b;

        }

        public int Multiply(int a, int b)
        {
            return a * b;

        }

        public int Divide(int a, int b)
        {
            return a / b;

        }

    }
}
