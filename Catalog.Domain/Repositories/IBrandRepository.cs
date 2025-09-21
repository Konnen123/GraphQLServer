using Catalog.Domain.Entities;
using Catalog.Domain.Utils;

namespace Catalog.Domain.Repositories;

public interface IBrandRepository
{
    Task<Result<Brand>> GetBrandByIdAsync(Guid brandId);
    Task<Result<IEnumerable<Brand>>> GetAllBrandsAsync();
    Task<Result<Guid>> AddBrandAsync(Brand brand);
    Task<Result> UpdateBrandAsync(Brand brand);
    Task<Result> DeleteBrandAsync(Guid brandId);
}