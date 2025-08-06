using GraphQL.API.Application.Services;
using GraphQL.API.Domain.Entities;

namespace GraphQL.API.GraphQL.Mutations
{
    [ExtendObjectType("Mutation")]
    public class ProductMutation
    {
        public Task<Product> AddProduct(string name, decimal price, int qty ,string description ,[Service] ProductService service)
        {
            var product = new Product { Id = Guid.NewGuid(), Name = name, Price = price, Qty=qty, Description=description };
            return service.AddAsync(product);
        }

        public async Task<Product?> UpdateProduct(Guid id, string name, decimal price,int qty, string description, [Service] ProductService service)
        {
            var existing = await service.GetByIdAsync(id);
            if (existing is null) return null;
            existing.Name = name;
            existing.Price = price;
            existing.Qty = qty;
            existing.Description = description;
            return await service.UpdateAsync(existing);
        }

        public Task<bool> DeleteProduct(Guid id, [Service] ProductService service) =>
            service.DeleteAsync(id);
    }
}
