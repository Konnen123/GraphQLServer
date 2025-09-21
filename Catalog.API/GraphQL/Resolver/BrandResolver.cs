using Catalog.Application.DTOs;
using Catalog.Application.Use_Cases.Queries;
using MediatR;

namespace Catalog.API.GraphQL.Resolver;

[QueryType]
public static class BrandResolver
{
    public static async Task<BrandDto?> GetBrandByIdAsync(Guid id, 
        IMediator mediator,
        CancellationToken cancellationToken)
    {
        Domain.Utils.Result<BrandDto> result = await mediator.Send(new GetBrandByIdQuery
        {
            Id = id
        }, cancellationToken);
        
        return result.IsSuccess ? result.Value! : null;
    }
    
    public static async Task<IEnumerable<BrandDto>> GetAllBrandsAsync(
        IMediator mediator,
        CancellationToken cancellationToken)
    {
        Domain.Utils.Result<IEnumerable<BrandDto>> result = await mediator.Send(new GetAllBrandsQuery(), cancellationToken);
        
        return result.IsSuccess ? result.Value! : Enumerable.Empty<BrandDto>();
    }
}