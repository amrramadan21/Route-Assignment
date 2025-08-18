using Assignment02_OOP02.First_Project;
using Assignment02_OOP02.Second_Project;
using Assignment02_OOP02.Third_Project;
using System.ComponentModel.Design.Serialization;

namespace Assignment02_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project 

            #region Q2

            //Point3D point = new Point3D(0, 0, 0);
            //point.X = 10;
            //point.Y = 10;
            //point.Z = 10;

            //Console.WriteLine($"Point Coordinates \n{point.ToString()}");  

            #endregion


            //Q4 inside Q3
            #region Q3

            //int[] p1 = new int[2]; // [X1, Y1]
            //int[] p2 = new int[2]; // [X2, Y2]

            //Console.WriteLine("Enter Point P1:");

            //Console.Write("Enter X1: ");
            //if (!int.TryParse(Console.ReadLine(), out p1[0]))
            //{
            //    Console.WriteLine("Invalid input for X1, set to 0");
            //    p1[0] = 0;
            //}

            //Console.Write("Enter Y1: ");
            //if (!int.TryParse(Console.ReadLine(), out p1[1]))
            //{
            //    Console.WriteLine("Invalid input for Y1, set to 0");
            //    p1[1] = 0;
            //}

            //Console.WriteLine("\nEnter Point P2:");

            //Console.Write("Enter X2: ");
            //if (!int.TryParse(Console.ReadLine(), out p2[0]))
            //{
            //    Console.WriteLine("Invalid input for X2, set to 0");
            //    p2[0] = 0;
            //}

            //Console.Write("Enter Y2: ");
            //if (!int.TryParse(Console.ReadLine(), out p2[1]))
            //{
            //    Console.WriteLine("Invalid input for Y2, set to 0");
            //    p2[1] = 0;
            //}

            //#region Q4

            //if (p1[0] == p2[0] && p1[1] == p2[1])
            //{
            //    Console.WriteLine("P1 and P2 are the same point");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are different points");
            //}


            //#endregion

            //Console.WriteLine($"\nPoint P1 = ({p1[0]}, {p1[1]})");
            //Console.WriteLine($"Point P2 = ({p2[0]}, {p2[1]})");

            #endregion

            #region Q5

            //Point[] points = new Point[]
            //{
            //    new Point { X = 3, Y = 5 },
            //    new Point { X = 1, Y = 9 },
            //    new Point { X = 1, Y = 2 },
            //    new Point { X = 2, Y = 4 }

            //};

            //Array.Sort(points, (a, b) =>
            //{
            //    int cmp = a.X.CompareTo(b.X); 
            //    if (cmp == 0)                  
            //        cmp = a.Y.CompareTo(b.Y); 
            //    return cmp;
            //});

            //Console.WriteLine("Sorted Points:");
            //foreach (var p in points)
            //    Console.WriteLine(p);

            #endregion

            #region Q6

            //    Point3D p1 = new Point3D(1, 2, 3);
            //    Point3D p2 = (Point3D)p1.Clone(); 

            //    Console.WriteLine("Original: " + p1);
            //    Console.WriteLine("Clone: " + p2);

            //    p2.X = 9;
            //    Console.WriteLine("\nAfter modification:");
            //    Console.WriteLine("Original: " + p1);
            //    Console.WriteLine("Clone: " + p2);

            //    Point3D[] arr =
            //    {
            //    new Point3D(2, 3, 1),
            //    new Point3D(1, 4, 5),
            //    new Point3D(1, 2, 2)
            //};

            //    Array.Sort(arr);

            //    Console.WriteLine("\nSorted Points:");
            //    foreach (var p in arr)
            //        Console.WriteLine(p);

            #endregion

            #endregion

            #region Second Project

            #region Call Methods

            //Maths m = new Maths();

            //Console.WriteLine($"Add :     {m.Add(10,5)}");
            //Console.WriteLine($"Subtract: {m.Subtract(10,5)}");
            //Console.WriteLine($"Multiply: {m.Multiply(10,5)}");
            //Console.WriteLine($"Divide:   {m.Divide(10, 5)}");


            #endregion

            #endregion

            #region Third Project

            #region Q3

            //Duration D1 =new Duration(1,10,15);
            //Console.WriteLine(D1.ToString());

            //D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            #endregion

            #region Q4

            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(7800); 

            //Duration D3;

            //D3 = D1 + D2;
            //Console.WriteLine(D3);  

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);  

            //D3 = 666 + D1;
            //Console.WriteLine(D3);  

            //D3 = ++D1;
            //Console.WriteLine(D3);  

            //D3 = --D2;
            //Console.WriteLine(D3);  

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //if (D1 > D2) Console.WriteLine("D1 > D2");
            //if (D1 <= D2) Console.WriteLine("D1 <= D2");

            //if (D1) Console.WriteLine("D1 is valid (>0)");

            //DateTime dt = (DateTime)D1;
            //Console.WriteLine("As DateTime: " + dt);

            #endregion

            #endregion
        }
    }
}
