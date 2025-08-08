using GraphQL.API.Application.Services;
using GraphQL.API.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace GraphQL.API.GraphQL.Queries
{

    [ExtendObjectType("Query")]  
    public class ProductQuery
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]

        [GraphQLName("get")]
        public Task<IEnumerable<Product>> GetProducts([Service] ProductService service) =>
            service.GetAllAsync();

        [GraphQLName("getbyid")]
        public Task<Product?> GetProductById(Guid id, [Service] ProductService service) =>
            service.GetByIdAsync(id);
    }
}
