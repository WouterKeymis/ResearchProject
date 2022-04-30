using Microsoft.Data.SqlClient;
using ResearchProject.DAL.Persistance.Enums;

namespace ResearchProject.DAL.Persistance.Interfaces
{
    internal interface IDbConnectionFactory
    {
        SqlConnection CreateDbConnection(DatabaseConnectionName connectionName);
    }
}