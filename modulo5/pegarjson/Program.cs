using System;

namespace pegarjson
{
    public class Catalog
    {
        public Product[] Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public bool IsAvailable { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}