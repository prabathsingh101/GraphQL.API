using GraphQL.API.Application.Services;
using GraphQL.API.Domain.Entities;

namespace GraphQL.API.GraphQL.Queries
{

    [ExtendObjectType("Query")]  
    public class ProductQuery
    {
        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        public Task<IEnumerable<Product>> GetProducts([Service] ProductService service) =>
            service.GetAllAsync();

        public Task<Product?> GetProductById(Guid id, [Service] ProductService service) =>
            service.GetByIdAsync(id);
    }
}
