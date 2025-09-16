using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_ADV03
{
    public class LibraryEngine
    {
        public delegate string BookDelegate(Book b);

        public static void ProcessBooks(List<Book> bList, Func<Book,string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
