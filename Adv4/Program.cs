namespace Adv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("1", "C#", new[] {"Hassaan", "MOhamed", "lashin"}, DateTime.Now, 600),
                new Book("2", "java", new[] {"omar"}, DateTime.Now, 300),
                new Book("3", "c++", new[] {"zaki", "yasser"}, DateTime.Now, 500)
            };

         
            BookDelegate title = BookFunctions.GetTitle;
            BookDelegate price = BookFunctions.GetPrice;
            BookDelegate authors = BookFunctions.GetAuthors;

            LibraryEngine.ProcessBooks(books, title);
            LibraryEngine.ProcessBooks(books, price);
            LibraryEngine.ProcessBooks(books, authors);

          
            Func<Book, string> func = BookFunctions.GetTitle;

            LibraryEngine.ProcessBooksv2(books, func);
        }
    }
}
