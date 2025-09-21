using Catalog.Application.DTOs;
using Catalog.Application.Use_Cases.Queries;
using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Catalog.Domain.Utils;
using MediatR;

namespace Catalog.Application.Use_Cases.QueryHandlers;

public class GetAllBrandByIdQueryHandler : IRequestHandler<GetAllBrandsQuery, Result<IEnumerable<BrandDto>>>
{
    private readonly IBrandRepository _brandRepository;

    public GetAllBrandByIdQueryHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<Result<IEnumerable<BrandDto>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {
        Result<IEnumerable<Brand>> result = await _brandRepository.GetAllBrandsAsync();
        if (result.IsSuccess)
        {
            IEnumerable<Brand> brands = result.Value!;
            return Result<IEnumerable<BrandDto>>.Success(brands.Select(brand => new BrandDto
            {
                Name = brand.Name,
                Description = brand.Description,
                CreatedAt = brand.CreatedAt
            }));
        }
        
        return Result<IEnumerable<BrandDto>>.Failure(result.ErrorMessage!);
    }
}