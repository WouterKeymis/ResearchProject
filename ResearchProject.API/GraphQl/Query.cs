using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using ResearchProject.DAL;
using ResearchProject.Models;

namespace ResearchProject.API.GraphQl
{
    public class Query
    {
        [UseProjection]
        [UseFiltering()]
        public IQueryable<Person> GetPersons([Service] ResearchProjectContext context)
        {
            return context.Persons;
        }

        
        [UseProjection]
        public IQueryable<Pet> GetPets([Service] ResearchProjectContext context)
        {
            return context.Pets;
        }
        
    }
}