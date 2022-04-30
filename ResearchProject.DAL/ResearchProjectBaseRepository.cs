using ResearchProject.DAL.Persistance.Enums;
using ResearchProject.DAL.Persistance.Interfaces;

namespace ResearchProject.DAL
{
    internal abstract class ResearchProjectBaseRepository : DbBaseRepository
    {
        public ResearchProjectBaseRepository(IDbConnectionFactory dbConnectionFactory) 
            : base(dbConnectionFactory.CreateDbConnection(DatabaseConnectionName.ResearchProject)) { }
    }
}