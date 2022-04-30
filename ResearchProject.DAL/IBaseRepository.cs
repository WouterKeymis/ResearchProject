using System.Threading.Tasks;

namespace ResearchProject.DAL
{
    public interface IBaseRepository
    {
        Task CloseConnection();
        Task OpenConnection();
    }
}