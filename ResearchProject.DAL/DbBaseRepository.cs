using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace ResearchProject.DAL
{
    internal abstract class DbBaseRepository : IBaseRepository, IDisposable, IAsyncDisposable
    {
        private readonly SqlConnection _sqlConnection;

        public DbBaseRepository(
            SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        protected IDbConnection DbConnection => _sqlConnection;

        public async Task OpenConnection()
        {
            if (_sqlConnection.State != ConnectionState.Open)
                await _sqlConnection.OpenAsync();
        }

        public async Task CloseConnection()
        {
            if (_sqlConnection.State != ConnectionState.Closed)
                await _sqlConnection.CloseAsync();
        }

        public void Dispose()
        {
            if (_sqlConnection.State != ConnectionState.Closed)
                _sqlConnection.Close();

            _sqlConnection.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            if (_sqlConnection.State != ConnectionState.Closed)
                await _sqlConnection.CloseAsync();

            await _sqlConnection.DisposeAsync();
        }
    }
}