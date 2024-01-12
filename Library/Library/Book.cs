using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Book
    {
        protected Book(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Price { get; private set; }
        public int Count { get; private set; }
        public virtual void setPrice(int price)
        {
            if (price < 0)
            {
                throw new Exception("price can't be under zero");

            }
            Price = price;
        }
        public virtual void setCount(int count)
        {
            if (count < 0)
            {
                throw new Exception("price can't be under zero");

            }
            Count = count;
        }

    
    }

    public class RentBook : Book
    {
        public RentBook(string name) : base(name)
        {

        }
        public int DailyPrice { get; set; }
        public override void setPrice(int price)
        {
            if (price > 500)
            {
                throw new Exception("price can't be more than 500");
            }

            base.setPrice(price);
        }
        public override void setCount(int count)
        {
            if (count > 200)
            {
                throw new Exception("count can't be more than 200");
            }
            base.setCount(count);
        }
    }
    public class SaleBook : Book
    {
        public SaleBook(string name) : base(name)
        {

        }
   
        public override void setPrice(int price)
        {
            if (price > 10000)
            {
                throw new Exception("price can't be more than 10000");
            }

            base.setPrice(price);
        }
        public override void setCount(int count)
        {
            if (count > 100)
            {
                throw new Exception("count can't be more than 100");
            }
            base.setCount(count);
        }

    }
  
}
