using System.Collections.Generic;
using productividad.Models;

namespace productividad.Services
{
    interface IProductsService
    {
        List<Product> Products { get; set; }
        string GetProductsPerCategory(IEnumerable<Product> products);
        string GetProductsSummary(IEnumerable<Product> products);
        IEnumerable<Product> RemoveUnavailableProducts(IEnumerable<Product> products);
    }
}