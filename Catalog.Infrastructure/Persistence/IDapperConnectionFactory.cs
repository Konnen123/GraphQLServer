using System.Data;

namespace Catalog.Infrastructure.Persistence
{
    public interface IDapperConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}