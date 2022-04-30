using System;
using ResearchProject.DAL.Persistance.Interfaces;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ResearchProject.DAL.Persistance.Enums;

namespace ResearchProject.DAL.Persistance
{
    internal class DapperDbConnectionFactory: IDbConnectionFactory
    {
        private readonly IDictionary<DatabaseConnectionName, string> _connectionDict;

        public DapperDbConnectionFactory(IDictionary<DatabaseConnectionName, string> connectionDict)
        {
            _connectionDict = connectionDict;
        }

        public SqlConnection CreateDbConnection(DatabaseConnectionName connectionName)
        {
            if (_connectionDict.TryGetValue(connectionName, out string connectionString))
            {
                return new SqlConnection(connectionString);
            }

            throw new ArgumentException("No connection string defined", nameof(connectionName));
        }
    }
}