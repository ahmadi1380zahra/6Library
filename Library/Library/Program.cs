using System;

namespace Library
{
    class Program
    {
        static IBook LibraryManangement = new Library();
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            static void Run()
            {
                var option = GetInt("1.add book \n 2.remove book \n 3.show book");
                switch (option)
                {
                    case 1:
                        {

                            var bookName = GetString("What's the book name?");
                            int type = GetInt("1-rent 2-sale");
                            if (type == 1)
                            {
                                int price = GetInt("how much is this book?");
                                int dailyPrice = GetInt("how much is this book per day?");
                                int count = GetInt("how many do you have of this book");
                                LibraryManangement.AddRentBook(bookName, count, price, dailyPrice);
                            }
                            if (type == 2)
                            {
                                int price = GetInt("how much is this book?");

                                int count = GetInt("how many do you have of this book");
                                LibraryManangement.AddSaleBook(bookName, count, price);
                            }

                            break;
                        }
                    case 2:
                        {

                            var bookName = GetString("What's the book name?");
                            LibraryManangement.RemoveBook(bookName);
                            break;
                        }
                    case 3:
                        {

                            LibraryManangement.ShowBook();
                            break;
                        }

                }
            }
        }
        static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;
        }

        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }
    }
}
