using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Catalog.Domain.Utils;
using Catalog.Infrastructure.Persistence;
using Catalog.Infrastructure.Queries;
using Dapper;

namespace Catalog.Infrastructure.Repositories;

public class BrandRepository : IBrandRepository
{
    private readonly IDapperConnectionFactory _dapperConnectionFactory;

    public BrandRepository(IDapperConnectionFactory dapperConnectionFactory)
    {
        _dapperConnectionFactory = dapperConnectionFactory;
    }

    public async Task<Result<Brand>> GetBrandByIdAsync(Guid brandId)
    {
        try
        {
            using var connection = _dapperConnectionFactory.CreateConnection();
            var brand = await connection.QueryFirstAsync<Brand>(BrandQueries.GetBrandById, new {BrandId = brandId});
            return Result<Brand>.Success(brand);
        } 
        catch (Exception ex)
        {
            return Result<Brand>.Failure($"An error occurred while retrieving the brand: {ex.Message}");
        }
    }

    public async Task<Result<IEnumerable<Brand>>> GetAllBrandsAsync()
    {
        try
        {
            using var connection = _dapperConnectionFactory.CreateConnection();
            var brands = await connection.QueryAsync<Brand>(BrandQueries.GetAllBrands);
            return Result<IEnumerable<Brand>>.Success(brands);
        }
        catch (Exception ex)
        {
            return Result<IEnumerable<Brand>>.Failure($"An error occurred while retrieving brands: {ex.Message}");
        }
    }

    public async Task<Result<Guid>> AddBrandAsync(Brand brand)
    {
        try
        {
            using var connection = _dapperConnectionFactory.CreateConnection();
            var brandId = await connection.ExecuteScalarAsync<Guid>(BrandQueries.AddBrand, 
                new {Name = brand.Name, Description = brand.Description});
            return Result<Guid>.Success(brandId);
        }
        catch (Exception ex)
        {
            return Result<Guid>.Failure($"An error occurred while adding the brand: {ex.Message}");
        }
    }

    public async Task<Result> UpdateBrandAsync(Brand brand)
    {
        try
        {
            using var connection = _dapperConnectionFactory.CreateConnection();
            await connection.ExecuteAsync(BrandQueries.UpdateBrand,
                new {Name = brand.Name, Description = brand.Description});
            
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"An error occurred while updating the brand: {ex.Message}");
        }
    }

    public async Task<Result> DeleteBrandAsync(Guid brandId)
    {
        try
        {
            using var connection = _dapperConnectionFactory.CreateConnection();
            await connection.ExecuteAsync(BrandQueries.DeleteBrand, new {BrandId = brandId});
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"An error occurred while deleting the brand: {ex.Message}");
        }
    }
}