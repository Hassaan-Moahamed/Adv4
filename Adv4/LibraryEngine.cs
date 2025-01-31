using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv4
{
    public delegate string BookDelegate(Book book);

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookDelegate fbtr)
        {
            foreach (Book B in books)
            {
                Console.WriteLine(fbtr(B));
            }
        }
        public static void ProcessBooksv2(List<Book> books, Func<Book, string> fbtr)
        {
            foreach (Book B in books)
            {
                Console.WriteLine(fbtr(B));
            }
        }
    }
}
