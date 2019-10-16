using productividad.Enums;
using productividad.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace productividad.Services
{
    class ProductsService : IProductsService
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
}