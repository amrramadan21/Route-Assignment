using AssignmentLINQ01.Data;
using static AssignmentLINQ01.Data.ListGenerator;
namespace AssignmentLINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            #region Restriction Operators

            #region Q1

            //var Result = ProductList?.Where(P => P.UnitsInStock == 0);
            //foreach (var item in Result ?? Enumerable.Empty<Product>()) { Console.WriteLine(item);}

            #endregion

            #region Q2

            //var Result = ProductList?.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            //foreach (var item in Result ?? Enumerable.Empty<Product>()) { Console.WriteLine(item); }


            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n > 5).OrderBy(n => n).ElementAt(1);
            //Console.WriteLine(result);
            #endregion

            #endregion

            #region Aggregate Operators

            #region Q1

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(A => A % 2 == 1);
            //Console.WriteLine(Result);

            #endregion

            #region Q2

            //var Result = CustomerList?.Select(C => new { C.CustomerName, OrdersCount = C.Orders.Count() });
            //foreach (var item in Result ?? Enumerable.Empty<object>()) { Console.WriteLine(item); }

            #endregion

            #region Q3

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, ProductsCount = c.Count() });

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q4

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region Q5

            //string[] EnglishDictionary = File.ReadAllLines("dictionary_english.txt");
            //var Result = EnglishDictionary.Sum(w => w.Length);
            //Console.WriteLine(Result);

            #endregion

            #region Q6
            //var result = EnglishDictionary.Min(w=> w.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q7
            //var result = EnglishDictionary?.Max(w=> w.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q8

            //var result = EnglishDictionary.Average(w => w.Length);
            //Console.WriteLine(result);

            #endregion

            #region Q9

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, TotalUnitsInStock = c.Sum(u => u.UnitsInStock) });

            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q10
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, CheapestProductPrice = c.Min(x=> x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q11
            //var result = from p in ProductList
            //             group p by p.Category
            //             into Category
            //             let minPrice = Category.Min(x => x.UnitPrice)
            //             from c in Category
            //             where c.UnitPrice == minPrice
            //             select new {  c.Category, c.ProductName , c.UnitPrice };

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q12

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, MostExpPrice = c.Max(x => x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item)

            #endregion

            #region Q13
            //var result = from p in ProductList
            //             group p by p.Category
            //             into Category
            //             let maxPrice = Category.Max(x => x.UnitPrice)
            //             from c in Category
            //             where c.UnitPrice == maxPrice
            //             select new { c.Category, c.ProductName, c.UnitPrice };

            //foreach (var item in result) Console.WriteLine(item);


            #endregion

            #region Q14
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, AveragePrice = c.Average(x => x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #endregion

            #region Ordering Operators

            #region Q1

            //var result = ProductList?.OrderBy(p => p.ProductName);
            //foreach (var item in result ?? Enumerable.Empty<object>()) { Console.WriteLine(item); }

            #endregion

            #region Q2

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q3

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q4

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(x => x.Length)
            //             .ThenBy(x => x);

            //foreach (var item in result) Console.Write(item + " ");

            #endregion

            #region Q5
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length)
            //                  .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result) Console.Write(item + " ")

            #endregion

            #region Q6
            //var result = ProductList.OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x.Length)
            //                  .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result) Console.Write(item + " ");
            #endregion

            #region Q8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(a=>a.ElementAt(1) == 'i').Reverse().ToList();
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #endregion

            #region Transformation Operators

            #region Q1
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w=> new {Lowercase =w.ToLower(), Uppercase = w.ToUpper() });
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q3
            //var result = ProductList.Select(p=> new {p.ProductID, p.ProductName, Price = p.UnitPrice});
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.SelectMany((a, i) => new[] { $"{a}: {(a == i ? "True" : "False")}" });

            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a => numbersB.Where(b => a < b)
            //, (a, b) => $"{a} is less than {b}");

            //Console.WriteLine("Pairs where a < b");
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region Q6
            //var result = CustomerList.SelectMany(c => c.Orders.Where(o => o.Total < 500));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q7

            //var result = CustomerList.SelectMany(c => c.Orders.Where(o => o.OrderDate >= DateTime.Parse("1-1-1998")));
            //foreach (var item in result) Console.WriteLine(item);

            #endregion
            #endregion
        }
    }
}
