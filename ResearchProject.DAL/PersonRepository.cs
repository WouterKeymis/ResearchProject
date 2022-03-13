using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ResearchProject.DAL.Interfaces;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ResearchProjectContext _context;
        public PersonRepository(ResearchProjectContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
        }

        public Person GetById(int id)
        {
            return _context.Persons.Find(id);
        }

        public void Insert(Person person)
        {
            _context.Persons.Add(person);
        }

        public void Update(Person person)
        {
            _context.Persons.Attach(person);
            _context.Entry(person).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var toBeDeleted = _context.Persons.Find(id);
            _context.Persons.Remove(toBeDeleted);
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}