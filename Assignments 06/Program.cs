namespace Assignments_06
{

    class Person
    {
        public string Name;
    } // Q2

    internal class Program
    {
        #region Methods
        #region Q1
        //public static void IncrementByValue(int x)
        //{
        //    x += 10;
        //    Console.WriteLine($"Increment By Value : {x}");
        //}

        //public static void IncrementByReference(ref int x)
        //{
        //    x += 10;
        //    Console.WriteLine($"Incremetnt By Reference : {x}");
        //} 
        #endregion

        #region Q2

        //static void ChangeNameByValue(Person p)
        //{
        //    p.Name = "Ali";  
        //    p = new Person();
        //    p.Name = "Sara"; 
        //    Console.WriteLine("Inside ChangeNameByValue: " + p.Name);
        //}


        //static void ChangeNameByReference(ref Person p)
        //{
        //    p.Name = "Ahmed";  
        //    p = new Person();
        //    p.Name = "Mona";   
        //    Console.WriteLine("Inside ChangeNameByReference: " + p.Name);
        //}

        #endregion

        #region Q3

        //public static void SumSub(int X,int Y ,out int Sum,out int Sub)
        //{
        //    Sum = X + Y;
        //    Sub = X - Y;
        //}

        #endregion

        #region Q4

        //public static int SumOfDigits(int number)
        //{
        //    int sum = 0;

        //    while (number != 0)
        //    {
        //        int digit = number % 10;
        //        sum += digit;            
        //        number /= 10;            
        //    }

        //    return sum;
        //}

        #endregion

        #region Q5

        //public static bool IsPrime(int number)
        //{

        //    if (number <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }

        //    return true;


        //}

        #endregion

        #region Q6

        //public static void MinMaxArray(int[] arr, out int min, out int max)
        //{
        //    min = arr[0];
        //    max = arr[0];

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //            min = arr[i];

        //        if (arr[i] > max)
        //            max = arr[i];
        //    }
        //}


        #endregion

        #region Q7

        //public static long Factorial(int number)
        //{
        //    long result = 1;

        //    for (int i = 2; i <= number; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}

        #endregion

        #region Q8

        //public static string ChangeChar(string original, int position, char newChar)
        //{
        //    if (position < 0 || position >= original.Length)
        //    {
        //        return "Invalid position!";
        //    }

        //    char[] chars = original.ToCharArray();
        //    chars[position] = newChar;
        //    return new string(chars);
        //}

        #endregion 
        #endregion

        static void Main(string[] args)
        {
            #region Call Functions
            #region Q1
            //int number = 5;
            //Console.WriteLine($"Original Number : {number}");

            //IncrementByValue(number);
            //Console.WriteLine($"After Increment By Value : {number}");

            //IncrementByReference(ref number);
            //Console.WriteLine($"After Increment By Reference : {number}"); 
            #endregion

            #region Q2

            //Person person = new Person();
            //person.Name = "Omar";

            //Console.WriteLine("Original Name: " + person.Name);

            //ChangeNameByValue(person);
            //Console.WriteLine("After ChangeNameByValue: " + person.Name); // Ali


            //ChangeNameByReference(ref person);
            //Console.WriteLine("After ChangeNameByReference: " + person.Name); // Mona


            #endregion

            #region Q3

            //int a, b;

            //Console.WriteLine("Enter The First Number : ");
            //int.TryParse(Console.ReadLine(), out a);

            //Console.WriteLine("Enter The Second Number : ");
            //int.TryParse(Console.ReadLine(),out b);

            //SumSub(a,b,out int SumResult,out int SubResult);
            //Console.WriteLine($"Sum Of Numbers : {SumResult}");
            //Console.WriteLine($"Sub Of Numbers : {SubResult}");

            #endregion

            #region Q4

            //int num;
            //Console.Write("Enter a number: ");
            // int.TryParse(Console.ReadLine(),out num);

            //int result = SumOfDigits(num);

            //Console.WriteLine("The sum of the digits of the number {0} is: {1}", num, result);

            #endregion

            #region Q5

            //int number;
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(),out number);

            //if (IsPrime(number))
            //    Console.WriteLine($"{number} is a Prime Number.");
            //else
            //    Console.WriteLine($"{number} is NOT a Prime Number.");

            #endregion

            #region Q6

            //int[] numbers = { 12, 5, 78, 3, 45, 9 };

            //MinMaxArray(numbers, out int minValue, out int maxValue);

            //Console.WriteLine("Minimum value: " + minValue);
            //Console.WriteLine("Maximum value: " + maxValue);

            #endregion

            #region Q7

            //Console.Write("Enter a number: ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //long fact = Factorial(input);

            //Console.WriteLine($"Factorial of {input} is: {fact}");

            #endregion

            #region Q8

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter position to change (0-based): ");
            //int pos = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter new character: ");
            //char newChar = Convert.ToChar(Console.ReadLine());

            //string result = ChangeChar(input, pos, newChar);

            //Console.WriteLine("Modified string: " + result);

            #endregion 
            #endregion

        }
    }
}
