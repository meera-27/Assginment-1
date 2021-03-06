using System;
using System.Collections.Generic;

namespace AssestManagement
{
    

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static Book book = new Book();


        static void Main(string[] args)
        {
            bool close = true;
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
        "1)Add book\n" +
        "2)Delete book\n" +
        "3)Search book\n" +
        "4)Update book\n" +
        "5)Close\n\n");
                Console.Write("Choose your option from menu :");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AddBook();
                }
                else if (option == 2)
                {
                    DeleteBook();
                }
                else if (option == 3)
                {
                    SearchBook();
                }
                else if (option == 4)
                {
                    UpdateBook();

                }

                else if (option == 5)
                {
                    Console.WriteLine("Thank you");

                }

                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }

            }

        }

        //To add book details to the AssestManagement
        public static void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Enter the category:");
            book.bookCategory = Console.ReadLine();
            bookList.Add(book);
        }

        //To delete book details from the AssestManagement
        public static void DeleteBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                foreach (Book DelId in bookList)
                {
                    Console.WriteLine("Book id - {0} has been deleted", Del);
                    Console.WriteLine(
                             "Book name :{1}\n" +
                             "Book Category :{2}\n", DelId.bookId, DelId.bookName, DelId.bookCategory);
                }
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
            //UpdateBook();
            bookList.Add(book);
        }

       
 
        //To search book details from the AssestManagement using Book id 
        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BooK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book Category :{2}\n", searchId.bookId, searchId.bookName, searchId.bookCategory);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        //To Update book details from the AssestManagement using Book id 
       public static void UpdateBook()
         {
           Book book = new Book();
             Console.WriteLine("Enter the book id to update: ");
             int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Updating menu");
             if(bookList.Exists(x => x.bookId == id)) { 
                 foreach (Book UpdateId in bookList) {
                     if(UpdateId.bookId == id) {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book Category :{2}\n", UpdateId.bookId, UpdateId.bookName, UpdateId.bookCategory);
                     }
                }   }


         }

    }
}