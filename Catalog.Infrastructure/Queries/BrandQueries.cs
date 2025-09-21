namespace Catalog.Infrastructure.Queries;

public static class BrandQueries
{
    public const string GetBrandById = @"
        SELECT Id, Name, Description, CreatedAt
        FROM brands
        WHERE Id = @BrandId;";
    
    public const string GetAllBrands = @"
        SELECT Id, Name, Description, CreatedAt
        FROM brands
        ORDER BY Name
        LIMIT 1000;";
    
    public const string AddBrand = @"
        INSERT INTO brands (Name, Description)
        VALUES (@Name, @Description) 
        RETURNING Id;";

    public const string UpdateBrand = @"
        UPDATE brands
        SET Name = @Name,
        Description = @Description
        WHERE Id = @Id;";
    
    public const string DeleteBrand = @"
        DELETE FROM brands
        WHERE Id = @BrandId;";
}