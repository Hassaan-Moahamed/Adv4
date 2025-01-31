using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv4
{
    public class Book
    {
       
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
      

      
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Authors[0]);

            for (int i = 1; i < Authors.Length; i++)
            {
                sb.Append(", ");
                sb.Append(Authors[i]);
            }

            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {sb}\nPublication Date: {PublicationDate}\nPrice: {Price}";

        }

       
    }
}
