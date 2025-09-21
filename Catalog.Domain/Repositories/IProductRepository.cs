using System.Diagnostics.CodeAnalysis;
using Catalog.Domain.Entities;
using Catalog.Domain.Utils;

namespace Catalog.Domain.Repositories;

public interface IProductRepository
{
    Task<Result<Product>> GetProductByIdAsync(Guid brandId);
    Task<Result<IEnumerable<Product>>> GetAllProductsAsync();
    Task<Result<Guid>> AddProductAsync(Product brand);
    Task<Result> UpdateProductAsync(Product brand);
    Task<Result> DeleteProductAsync(Guid brandId);
}