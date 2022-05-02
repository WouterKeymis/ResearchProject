using System.Collections.Generic;
using System.Threading.Tasks;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAll();
        Task<Person> GetById(int personId);
        Task<IEnumerable<Pet>> GetPetsByPersonId(int personId);
        Task<IEnumerable<Address>> GetAddressesByPersonId(int personId);
        Task<IEnumerable<Person>> GetPersonsByCity(string city);

    }
}