using Catalog.Application.DTOs;
using Catalog.Domain.Utils;
using MediatR;

namespace Catalog.Application.Use_Cases.Queries;

public class GetAllBrandsQuery : IRequest<Result<IEnumerable<BrandDto>>>
{
    
}