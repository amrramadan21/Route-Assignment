using System.Windows.Markup;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q19


            //Console.WriteLine("Enter The Size Of Identity Matrix : ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[n,n];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) 
            //    {
            //        if (j == i)
            //        {
            //            matrix[i,j] = 1;
            //        }
            //        Console.WriteLine(matrix[i,j]);
            //    }
            //    Console.WriteLine();

            //}




            #endregion

            #region Q20


            //Console.Write("Enter the number of elements in the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];
            //int sum = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}

            //Console.WriteLine($"\nSum of all elements in the array = {sum}");


            #endregion

            #region Q21

            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];

            //Console.WriteLine("\nEnter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nEnter elements for the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = array1.Concat(array2).ToArray();

            //Array.Sort(mergedArray);

            //Console.WriteLine("\nMerged and Sorted Array in Ascending Order:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion

            #region Q22



            #endregion

            #region Q23

            ////Console.Write("Enter The Number Of Elements:  ");
            ////int size = int.Parse(Console.ReadLine());

            ////int[] values = new int[size];
            ////int max = values[0];
            ////int min = values[0];

            ////for (int i = 0; i < size; i++)
            ////{
            ////    Console.WriteLine($"Enter The Values {i+1} : ");
            ////    values[i] = int.Parse(Console.ReadLine());
            ////    max = Math.Max(max, values[i]);
            ////    min = Math.Min(min, values[i]);

            ////}

            //////for (int i = 1; i < size; i++)
            //////{ 
            //////    if (values[i] > max)
            //////        max = values[i];

            //////    if (values[i] < min)
            //////        min = values[i];
            //////}
            ////Console.WriteLine($"Maximum Value: {max}");
            ////Console.WriteLine($"Minimum Value: {min}");





            #endregion

            #region Q24

            //int[] element;
            //element = new int[5];
            //Console.WriteLine("Enter The Elements : ");

            //for (int i = 0; i < element.Length; i++)
            //{ 
            //    int.TryParse(Console.ReadLine(), out element[i]);
            //}

            //Array.Sort(element);
            //Array.Reverse(element);

            //Console.WriteLine($"The Second Largest Element is : {element[1]}");

            #endregion

            #region Q25

            //int N;
            //int[] values;
            //int numberOfcells = 0;

            //Console.WriteLine("Enter Number Of Elements (N) : ");
            //int.TryParse(Console.ReadLine(),out N);

            //values = new int[N];

            //Console.WriteLine("Enter The Integer Values : ");
            //for (int i = 0; i < values.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out values[i]);
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    int firstIndex = Array.IndexOf(values, values[i]);
            //    int lastIndex = Array.LastIndexOf(values, values[i]);

            //    if (lastIndex > firstIndex)
            //    {
            //        int currentDistance = lastIndex - firstIndex - 1;

            //        if (currentDistance > maxDistance)
            //        {
            //            maxDistance = currentDistance;
            //        }
            //    }
            //}

            //numberOfcells = maxDistance;
            //Console.WriteLine($"Number Of Cells Between Fisrt And Last Same Elemetnts :{numberOfcells} ");

            #endregion

            #region Q26

            //Console.WriteLine("Enter The text: ");
            //string text = Console.ReadLine();

            //string[] words =text.Split(' ');
            //Array.Reverse(words);

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}

            #endregion

            #region Q27


            //Console.WriteLine("Enter the Size of the array n*m");
            //int n =int.Parse(Console.ReadLine());
            //int m =int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[n,m];
            //int[,] arr2 = new int[n, m];


            //for (int i = 0; i < n; i++)
            //{
            //    for (int  j = 0; j < m; j++)
            //        arr1[i,j] = int.Parse(Console.ReadLine());

            //}
            //Array.Copy(arr1 , arr2, arr1.Length);

            //for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < m; j++)
            //            Console.Write(arr2[i,j] + " ");

            //        Console.WriteLine();

            //    }

            #endregion

            #region 28

            //int[] numbers;
            //Console.WriteLine("Enter The Numbers: ");
            //numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out numbers[i]);

            //}
            
            //Array.Reverse(numbers);

            //Console.Clear();

            //Console.WriteLine($"The Number After Reverse:");

            //for (int i = 0;i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);


            #endregion

        }
    }
}
