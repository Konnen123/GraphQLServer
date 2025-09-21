using Catalog.Domain.Entities;
using Catalog.Domain.Utils;

namespace Catalog.Domain.Repositories;

public interface IProductTypeRepository
{
    Task<Result<ProductType>> GetProductTypeByIdAsync(Guid productTypeId);
    Task<Result<IEnumerable<ProductType>>> GetAllProductTypesAsync();
    Task<Result<Guid>> AddProductTypeAsync(ProductType productType);
    Task<Result> UpdateProductTypeAsync(ProductType productType);
    Task<Result> DeleteProductTypeAsync(Guid productTypeId);
}