namespace Assignment03_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
        {
            new Book("111", "C# Basics", new string[]{"John", "Jane"}, new DateTime(2020,5,1), 300),
            new Book("222", "Advanced C#", new string[]{"Alice"}, new DateTime(2022,10,15), 450)
        };

            Console.WriteLine("=== User Defined Delegate ===");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            Console.WriteLine("\n=== BCL Delegate (Func) ===");
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetAuthors));

            Console.WriteLine("\n=== Anonymous Method (GetISBN) ===");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("\n=== Lambda Expression (GetPublicationDate) ===");
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());
        }
    }
}
