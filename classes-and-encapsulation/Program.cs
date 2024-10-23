using System;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book
        {
            Title = "The Furious Fortitude",
            Author = "Dangus Dangle",
            Price = 16.50,
        };

        book.DisplayBookInfo();
        book.Price = -45;

    }

    class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        private double price = 0;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price must be greater than zero.");
                }
                else
                {
                    price = value;
                }
            }
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");
        }
    }
}
