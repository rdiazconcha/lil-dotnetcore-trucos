using productividad.Enums;
using System.Diagnostics;

namespace productividad.Models
{
    [DebuggerDisplay("{Name,nq}")]
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}