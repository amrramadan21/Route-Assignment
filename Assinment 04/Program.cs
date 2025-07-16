using System.ComponentModel;

namespace Assinment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q6

            //int number;
            //Console.WriteLine("Please Enter The Number: ");
            //int.TryParse(Console.ReadLine(), out number);

            //for (int i = 1; i <= number; i++)
            //    Console.WriteLine(i);

            #endregion

            #region Q7

            //int number;
            //Console.WriteLine("Please Enter Your Number: ");
            //int.TryParse(Console.ReadLine(), out number);

            //Console.WriteLine($"Multiplication Table For {number}");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} * {i} ={number} * {i}");
            //}

            #endregion

            #region Q8

            //int number;
            //Console.WriteLine("Please Enter The Number: ");
            //int.TryParse(Console.ReadLine(), out number);

            //Console.WriteLine($"Even Number Between 1 and {number}");

            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            #endregion

            #region Q9

            //int num01, num02;
            //double power;
            //Console.WriteLine("Please Enter The Numbers: ");
            //int.TryParse(Console.ReadLine(), out num01);
            //int.TryParse (Console.ReadLine(), out num02);

            //power = Math.Pow(num01, num02);
            //Console.WriteLine(power);

            #endregion

            #region Q10

            //int[] marks = new int[5];
            //int total = 0;
            //Console.WriteLine("Enter Marks Of Five Subject: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total = total + marks[i];
            //}
            //double average = total / marks.Length;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");

            #endregion

            #region Q11

            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:  // January
            //    case 3:  // March
            //    case 5:  // May
            //    case 7:  // July
            //    case 8:  // August
            //    case 10: // October
            //    case 12: // December
            //        Console.WriteLine("Number of days: 31");
            //        break;

            //    case 4:  // April
            //    case 6:  // June
            //    case 9:  // September
            //    case 11: // November
            //        Console.WriteLine("Number of days: 30");
            //        break;

            //    case 2:  // February
            //        Console.WriteLine("Number of days: 28 or 29 (leap year)");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //        break;
            //}


            #endregion

            #region Q12

            //    double num1, num2, result = 0;
            //    char operation;


            //    Console.Write("Enter first number: ");
            //    num1 = double.Parse(Console.ReadLine());


            //    Console.Write("Enter an operator (+, -, *, /): ");
            //    operation = char.Parse(Console.ReadLine());


            //    Console.Write("Enter second number: ");
            //    num2 = double.Parse(Console.ReadLine());


            //    switch (operation)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;

            //        case '-':
            //            result = num1 - num2;
            //            break;

            //        case '*':
            //            result = num1 * num2;
            //            break;

            //        case '/':
            //            if (num2 != 0)
            //                result = num1 / num2;
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //                return;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator.");
            //            return;
            //    }


            //    Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}");
            //}

            #endregion

            #region Q13


            //Console.WriteLine("Please Enter A String: ");
            //string name =  Console.ReadLine();

            //string reversed = new string(name.Reverse().ToArray());

            //Console.WriteLine($"Reversed String: {reversed} ");

            #endregion

            #region Q14

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //string reversed = new string(number.ToString().Reverse().ToArray());

            //Console.WriteLine($"Reversed number: {reversed} ");

            #endregion

            #region Q15

            //Console.WriteLine("Enter Starting number of range");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Ending number of range");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    int count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0) count++;
            //        if (count > 2) break;
            //    }        

            //    if (count == 2)
            //        Console.Write($"{i} ");


            //}

            #endregion

            #region Q17

            //Console.WriteLine("Enter the First Point");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Point");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third Point");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //double m1 = (y2 - y1) / (x2 - x1);
            //double m2 = (y3 - y1) / (x3 - x1);
            //if (m1 == m2)
            //    Console.WriteLine("They Lie on a single straight line");
            //else
            //    Console.WriteLine("They Don't lie on a single straight line");

            #endregion

            #region Q18

            //Console.WriteLine("Enter the time taken for the task");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("Highly Efficient");
            //else if (time > 3 && time <= 4)
            //    Console.WriteLine("Increase Your Speed");
            //else if (time > 4 && time <= 5)
            //    Console.WriteLine("Train to enhance your speed");
            //else if (time > 5)
            //    Console.WriteLine("Leave The Company");

            #endregion


        }
    }   
}
