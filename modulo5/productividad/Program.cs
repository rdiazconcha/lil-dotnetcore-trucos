using productividad.Models;
using productividad.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace productividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Lista de productos");
            Console.WriteLine("******************");

            IProductsService productsService = new ProductsService();

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