using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.API.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = "";
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public string? Description { get; set; } = "";
    }
}
