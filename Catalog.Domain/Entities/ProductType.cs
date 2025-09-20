namespace Catalog.Domain.Entities;

public class ProductType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}