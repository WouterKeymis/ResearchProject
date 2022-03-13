using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ResearchProject.DAL.Interfaces;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ResearchProjectContext _context;

        public AddressRepository(ResearchProjectContext context)
        {
            _context = context;
        }
        public IEnumerable<Addres> GetAll()
        {
            return _context.Addresses;
        }

        public IEnumerable<Addres> GetByPersonId(int id)
        {
            return _context.Addresses.Where(a => a.PersonId == id);
        }

    }
}