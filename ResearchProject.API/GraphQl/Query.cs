using System.Linq;
using HotChocolate;
using ResearchProject.DAL;
using ResearchProject.Models;

namespace ResearchProject.API.GraphQl
{
    public class Query
    {
        public IQueryable<Person> GetPerson([Service] ResearchProjectContext context) => context.Persons;
    }
}