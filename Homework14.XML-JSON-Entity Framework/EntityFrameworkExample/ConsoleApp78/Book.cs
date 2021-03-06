//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp78
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Publisher Publisher { get; set; }

        public static void InsertBook(string title, Publisher publisherId, int year, decimal price)
        {
            Book book = new Book()
            {
                Title = title,
                PublisherId = publisherId.PublisherId,
                Year = year,
                Price = price,

            };

            if (book != null)
            {
                using (BookPublisherEntities bp = new BookPublisherEntities())
                {
                    bp.Books.Add(book);
                    bp.SaveChanges();
                }
            }

            Console.WriteLine("Book has been added");

        }
    }

 
}
