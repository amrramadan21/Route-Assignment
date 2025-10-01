using AssignmentLINQ02.Data;
using System.Collections.Generic;
using static AssignmentLINQ02.Data.ListGenerator;

namespace Assignment_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Set Operators

            #region Q1

            //var Result = ProductList?.DistinctBy(P => P.Category);
            //foreach (var item in Result ?? Enumerable.Empty<object>()) { Console.WriteLine(item); }

            #endregion

            #region Q2

            //var Result = ProductList?.Select(P => P.ProductName?[0]).Union(CustomerList?.Select(C => C.CustomerName?[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3

            //var result = ProductList?.Select(p => p.ProductName?[0]).Intersect(CustomerList?.Select(c => c.CustomerName?[0]));
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q4

            //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q5
            //var result = ProductList.Select(p => p.ProductName.TakeLast(3).ToArray())
            //    .Concat(CustomerList.Select(c => c.CustomerName.TakeLast(3).ToArray()));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #endregion

            #region Quantifiers

            #region Q1

            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt");
            //var Result = EnglishDic.Any(W => W.Contains("ei"));
            //Console.WriteLine(Result); 

            #endregion

            #region Q2
            //var Reslut = from P in ProductList
            //             group P by P.Category
            //             into C
            //             where C.Any(C => C.UnitsInStock == 0)
            //             from P in C
            //             select new {Category = C.Key, Product = P};
            //foreach (var item in Reslut)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //var Reslut = from P in ProductList
            //             group P by P.Category
            //             into C
            //             where C.Any(C => C.UnitsInStock > 0)
            //             from P in C
            //             select new {Category = C.Key, Product = P};
            //foreach (var item in Reslut)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Grouping Operators

            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(x => x % 5).Select(c => new {c.Key,c});

            //foreach (var result in Result)
            //{
            //    Console.WriteLine($"Number with remaider of {result.Key} when divided by 5 ");
            //        foreach (var n in result.c)
            //        {
            //           Console.WriteLine(n);
            //        }
            //}


            #endregion

            #region Q2
            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt");
            //var list = EnglishDic.GroupBy(w => w[0]).ToList().Select(c => new {c.Key,c});
            //foreach (var item in list) 
            //{
            //    Console.WriteLine(item.Key);

            //}


            #endregion

            #region Q3
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr.GroupBy(a => a, new MatchStringComparer()).Select(x => new { x.Key, x });
            //foreach (var item in result)
            //{
            //    foreach (var w in item.x)
            //        Console.WriteLine(w);
            //    Console.WriteLine("------");
            //}
            #endregion

            #endregion

            #region Partitioning Operators

            #region Q1
            //var Result = CustomerList.Where(c  => c.City == "Washington").Select(c => c.Orders).Take(3);

            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //} 
            #endregion

            #region Q2
            //var Result = CustomerList.Where(c  => c.City == "Washington").Select(c => c.Orders).Take(2);

            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //} 
            #endregion

            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .TakeWhile((num, index) => num >= index)   
            //    .ToList();

            //Console.WriteLine(string.Join(", ", result));
            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .SkipWhile(n => n % 3 != 0)   
            //    .ToList();

            //Console.WriteLine(string.Join(", ", result));
            #endregion

            #region Q5

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .SkipWhile((num, index) => num >= index)  
            //    .ToList();

            //Console.WriteLine(string.Join(", ", result));
            #endregion
            #endregion

        }
    }
}
