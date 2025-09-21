using Catalog.Application.DTOs;
using Catalog.Domain.Utils;
using MediatR;

namespace Catalog.Application.Use_Cases.Queries;

public class GetBrandByIdQuery : IRequest<Result<BrandDto>>
{
    public required Guid Id { get; set; }
    
}