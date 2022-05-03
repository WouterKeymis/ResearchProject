using ResearchProject.Models;
using System.Threading.Tasks;
using Dapper;
using ResearchProject.DAL.Persistance.Interfaces;

namespace ResearchProject.DAL
{
    internal class VetenaryRepository : ResearchProjectBaseRepository, IVetenaryRepository
    {
        public VetenaryRepository(IDbConnectionFactory connectionFactory): base(connectionFactory)
        {
            
        }
        public async Task<Veterinary> GetVetByPetId(int vetId)
        {
            var parameters = new { vetId };
            var sql = $"SELECT * FROM Veterinaries WHERE Id = @{nameof(vetId)}";
            var vet = await DbConnection.QueryFirstOrDefaultAsync<Veterinary>(sql, parameters);
            return vet;
            
        }
    }
}