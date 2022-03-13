using System.Collections.Generic;
using ResearchProject.Models;

namespace ResearchProject.DAL.Interfaces
{
    public interface IAddressRepository
    {
        IEnumerable<Addres> GetAll();
        IEnumerable<Addres> GetByPersonId(int id);
    }
}