using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text.Json;
using System.Net.Http;
using System.Text;
using System.Diagnostics;

namespace depuracion
{
    enum Category
    {
        Food,
        Technology
    }

    [DebuggerDisplay("{Name,nq}")]
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    class ProductsService
    {
        public List<Product> Products { get; set; }
        public ProductsService()
        {
            using var file = File.OpenRead(@"c:\curso\products.json");
            using var reader = new StreamReader(file);
            var contents = reader.ReadToEnd();
            Products = JsonSerializer.Deserialize<List<Product>>(contents);
        }
        public IEnumerable<Product> RemoveUnavailableProducts(IEnumerable<Product> products)
        {
            return products.Where(p => p.IsAvailable).AsEnumerable();
        }

        public string GetProductsSummary(IEnumerable<Product> products)
        {
            return $"Hay {products.Count()} productos. {GetProductsPerCategory(products)}";
        }

        public string GetProductsPerCategory(IEnumerable<Product> products)
        {
            return $"comida: ({products.Count(p => p.Category == Category.Food)}) tecnología: ({products.Count(p => p.Category == Category.Technology)})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Lista de productos");
            Console.WriteLine("******************");

            var productsService = new ProductsService();

            DisplayProducts(productsService.Products);

            Console.WriteLine(productsService.GetProductsSummary(productsService.Products));

            Console.WriteLine("Fin");
            Console.ReadLine();
        }

        static void DisplayProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}