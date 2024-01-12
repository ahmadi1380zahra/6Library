using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     class Library : IBook
    {
        public static List<Book> books = new List<Book>();
         public void AddRentBook(string name, int count, int price, int dailyPrice)
        {
            var rentBook = new RentBook(name);
            rentBook.setCount(count);
            rentBook.setPrice(price);
            rentBook.DailyPrice = dailyPrice;
            if (books.Any(item => item.Name == name))
            {
                throw new Exception("name should be unique");
            }
            books.Add(rentBook);
        }

        public void AddSaleBook(string name, int count, int price)
        {
            var saleBook = new SaleBook(name);
            saleBook.setCount(count);
            saleBook.setPrice(price);
            if (books.Any(item => item.Name == name))
            {
                throw new Exception("name should be unique");
            }
            books.Add(saleBook);
        }

        public void RemoveBook(string name)
        {
            var book = books.Find(item=>item.Name==name);
            if(book is null)
            {
                throw new Exception("book  not found ");
            }
            books.Remove(book);
        }

        public void ShowBook()
        {
            foreach (var book  in books)
            {
                Console.WriteLine($"{book.Name } is  {(book is RentBook? "for Rent ":"for Sale")} we have {book.Count} of this and the price is {book.Price}");
            }
        }
    }
}
