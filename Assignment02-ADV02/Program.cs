using System.Collections;
using System.Collections.Generic;


namespace Assignment02_ADV02
{
    internal class Program
    {
        #region Q1
        static  void RevesrseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object? temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }

        }
        #endregion

        #region Q2

        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evens.Add(num);

            }
                return evens;
        }

        #endregion

        #region Q4

        static int UpperBound(int[] arr, int target)
        {
            int left = 0, right = arr.Length;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] <= target)
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
        #endregion

        #region Q5

        static bool IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        #endregion

        #region Q6
        static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                set.Add(num); 
            }

            return new List<int>(set).ToArray();
            }

        #endregion

        #region Q7

        static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int value = (int)list[i];
                if (value % 2 != 0) 
                {
                    list.RemoveAt(i);
                }
            }
        }

        #endregion


        static void Main(string[] args)
        {
            #region Q1

            //ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Before Reverse:");
            //foreach (var item in arr)
            //    Console.Write(item + " ");

            //RevesrseArrayList(arr);

            //Console.WriteLine("\nAfter Reverse:");
            //foreach (var item in arr)
            //    Console.Write(item + " ");

            #endregion

            #region Q2

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> evenNums = GetEvenNumbers(nums);

            //Console.WriteLine("Even Numbers: " + string.Join(", ", evenNums));


            #endregion

            #region Q3

            //FixedSizeList<int> myList = new FixedSizeList<int>(3);

            //myList.Add(10);
            //myList.Add(20);
            //myList.Add(30);

            //Console.WriteLine("Item at index 1: " + myList.Get(1)); 

            //try
            //{
            //    myList.Add(40);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //try
            //{
            //    Console.WriteLine(myList.Get(5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            #endregion

            #region Q4

            //Console.Write("Enter size of array (N): ");
            //int.TryParse(Console.ReadLine(), out int N);

            //int[] arr = new int[N];
            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < N; i++)
            //    int.TryParse(Console.ReadLine(), out arr[i]);

            //Array.Sort(arr);

            //Console.Write("Enter number of queries (Q): ");
            //int.TryParse(Console.ReadLine(), out int Q);

            //for (int q = 0; q < Q; q++)
            //{
            //    Console.Write("Enter X: ");
            //    int.TryParse(Console.ReadLine(), out int X);

            //    int index = UpperBound(arr, X);

            //    int count = N - index;
            //    Console.WriteLine(count);
            //}

            #endregion

            #region Q5

            //Console.Write("Enter size of array (N): ");
            //int.TryParse(Console.ReadLine(),out int n);

            //int[] arr = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(),out arr[i]);
            //}

            //if (IsPalindrome(arr))
            //{
            //    Console.WriteLine("The array is a Palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The array is NOT a Palindrome.");
            //}

            #endregion

            #region Q6

            //int[] arr = { 1, 2, 3, 2, 4, 3, 5, 1 };

            //int[] uniqueArr = RemoveDuplicates(arr);

            //Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueArr));

            #endregion

            #region Q7

            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            //RemoveOddNumbers(list);

            //Console.WriteLine("ArrayList after removing odd numbers:");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion
        }
        
    }
}
