using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    class Database
    {

        public static void InsertBook(string title, Publisher publisherId, int year, decimal price)
        {

            using (Library2 lib = new Library2())
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
                    lib.Book.Add(book);
                    lib.SaveChanges();

                }
                Console.WriteLine($"Book no {book.BookId} has been inserted");
            }
        }

        public static void DeleteBook(int bookId)
        {
            using (Library2 lib = new Library2())
            {
                lib.Book.RemoveRange(from b in lib.Book
                                      where b.BookId == bookId
                                      select b);

                lib.SaveChanges();

                Console.WriteLine($"Book no {bookId} has been deleted");
            }
        }

        public static List<Book> ListBooks()
        {
            using(Library2 lib  = new Library2())
            {
                var list = (from b in lib.Book
                            select b).ToList();

                return list;
                
            }

        }

        public static void PrintBooks(List<Book> list)
        {
            foreach(var elem in list)
            {
                Console.WriteLine($"{elem.BookId}, {elem.Title}, {elem.Year},{elem.Price}");
            }
        }
        
    }
}
