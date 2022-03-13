using System.Collections.Generic;
using ResearchProject.Models;

namespace ResearchProject.DAL.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        void Insert(Person person);
        void Update(Person person);
        void Delete(int id);
        void Save();
    }
}