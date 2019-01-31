using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {

            BookPublisherEntities bp = new BookPublisherEntities();

            //AllBooksWhereYearIs2017(bp);

            //AddBook(bp);

            //RemoveMultipleRecords(bp);

            //RemoveBookWhereIdIs1(bp);

            //Update();

            //SelectAllPublishers();

            //DeletePublisher();

            

            Console.ReadKey();
        }

        private static void DeletePublisher()
        {
            using(BookPublisherEntities bp  = new BookPublisherEntities())
            {
                bp.Publishers.RemoveRange( from b in bp.Publishers
                          where b.Name.Contains("Mihai")
                          select b);
                bp.SaveChanges();
                          
            }
        }

        private static void SelectAllPublishers()
        {
            using(BookPublisherEntities bp = new BookPublisherEntities())
            {
                var pun = from b in bp.Publishers
                          select b;

                foreach (var elem in pun)
                {
                    Console.WriteLine($"{elem.PublisherId}, {elem.Name}");
                }


            }
        }

        private static void Update()
        {
            using (BookPublisherEntities bp = new BookPublisherEntities())
            {
                var update = bp.Books.SingleOrDefault(b => b.Title == "Fluturi");

                if (update != null)
                {
                    update.Price = 5;
                    bp.SaveChanges();
                }

            }
        }

        private static void RemoveBookWhereIdIs1(BookPublisherEntities bp)
        {
            bp.Books.RemoveRange(from b in bp.Books
                                 where b.BookId == 1
                                 select b);
            bp.SaveChanges();
        }

        private static void RemoveMultipleRecords(BookPublisherEntities bp)
        {
            bp.Books.RemoveRange(from b in bp.Books
                                 where b.Title == "sdfd"
                                 select b);
            bp.SaveChanges();
        }

        private static void AddBook(BookPublisherEntities bp)
        {
            Book book1 = new Book()
            {

                Title = "Nemuritorul",
                PublisherId = 2,
                Year = 2015,
                Price = 10
            };

            bp.Books.Add(book1);
            bp.SaveChanges();
        }

        private static void AllBooksWhereYearIs2017(BookPublisherEntities bp)
        {
            var booksWhereYearIs2017 = (from b in bp.Books   //select * books where year  = 2017
                                        where b.Year == 2017
                                        select b).ToList();

            foreach (var elem in booksWhereYearIs2017)
            {
                Console.WriteLine($"{elem.BookId}, {elem.Title}, {elem.Price}");
            }
        }

    }
}
