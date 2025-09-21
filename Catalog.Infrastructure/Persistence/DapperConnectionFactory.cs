using Microsoft.Extensions.Configuration;
using System.Data;
using Npgsql;

namespace Catalog.Infrastructure.Persistence;

public class DapperConnectionFactory : IDapperConnectionFactory
{
    private readonly string _connectionString;

    public DapperConnectionFactory(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection")!;
    }

    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}