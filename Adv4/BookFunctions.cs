using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv4
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book is null)
            {
                return "Not Founded";
            }

            return $"Title: {book.Title}";
        }

        public static string GetAuthors(Book book)
        {
            if (book is null)
            {
                return "Not Founded";
            }
            StringBuilder sb = new StringBuilder(book.Authors[0]);

            for (int i = 1; i < book.Authors.Length; i++)
            {
                sb.Append(", ");
                sb.Append(book.Authors[i]);
            }

            return $"Authors: {sb}";
        }

        public static string GetPrice(Book book)
        {
            if (book is null)
            {
                return "Not Founded";
            }

            return $"BookPrice: {book.Price}";
        }

    }
}
