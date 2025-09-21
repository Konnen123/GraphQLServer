using Catalog.Application.DTOs;
using Catalog.Application.Use_Cases.Queries;
using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Catalog.Domain.Utils;
using MediatR;

namespace Catalog.Application.Use_Cases.QueryHandlers;

public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Result<BrandDto>>
{
    private readonly IBrandRepository _brandRepository;

    public GetBrandByIdQueryHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<Result<BrandDto>> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
    {
        Result<Brand> result = await _brandRepository.GetBrandByIdAsync(request.Id);
        if (result.IsSuccess)
        {
            Brand brand = result.Value!;
            return Result<BrandDto>.Success(new BrandDto
            {
                Name = brand.Name,
                Description = brand.Description,
                CreatedAt = brand.CreatedAt
            });
        }
        
        return Result<BrandDto>.Failure(result.ErrorMessage!);
    }
}