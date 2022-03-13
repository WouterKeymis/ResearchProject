using System.Collections.Generic;
using System.Linq;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public class ResearchProjectContextSeed
    {
        public static void SeedAsync(ResearchProjectContext context)
        {
            if (context.Persons.Any()) return;

            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Wouter",
                    LastName = "Keymis",
                    Age = 36
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Jasper",
                    LastName = "Dirix",
                    Age = 36
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Melissa",
                    LastName = "Schoofs",
                    Age = 36
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Glenn",
                    LastName = "DePrins",
                    Age = 36
                }
            };

            var addresses = new List<Addres>
            {
                new Addres
                {
                    Id = 1,
                    StreetName = "Sint-Lambertusstraat",
                    HouseNumber = 40,
                    PostCode = "3940",
                    City = "Hechtel-Eksel",
                    PersonId = 1
                },
                new Addres
                {
                    Id = 2,
                    StreetName = "Kloosterstraat",
                    HouseNumber = 22,
                    PostCode = "3990",
                    City = "Peer",
                    PersonId = 1
                }
            };


            context.Persons.AddRange(persons);
            context.Addresses.AddRange(addresses);

            context.SaveChanges();
        }
    }
}