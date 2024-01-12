using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IBook
    {
     
        void AddSaleBook(string name, int count, int price);
        void AddRentBook(string name, int count, int price,int dailyPrice);
       void RemoveBook(string name);
        void ShowBook();
    }
}
