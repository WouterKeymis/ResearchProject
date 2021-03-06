using ResearchProject.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Dapper;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using ResearchProject.DAL.Persistance.Interfaces;

namespace ResearchProject.DAL
{
    internal class PersonRepository : ResearchProjectBaseRepository, IPersonRepository
    {
        public PersonRepository(IDbConnectionFactory dbConnectionFactory): base(dbConnectionFactory) { }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var sql = "SELECT * FROM Persons";

            var allPersons = await DbConnection.QueryAsync<Person>(sql);

            return allPersons;
        }

        public async Task<Person> GetById(int personId)
        {
            var parameters = new {personId};

            var sql = $"SELECT * FROM Persons WHERE Id = @{nameof(personId)}";

            var person = await DbConnection.QueryFirstOrDefaultAsync<Person>(sql, parameters);

            var result = person;

            return person;
        }

        public async Task<IEnumerable<Address>> GetAddressesByPersonId(int personId)
        {
            var parameters = new { personId };

            var sql = $"SELECT * FROM Addresses WHERE PersonId = @{nameof(personId)}";

            var addresses = await DbConnection.QueryAsync<Address>(sql, parameters);

            return addresses;

        }

        public async Task<IEnumerable<Pet>> GetPetsByPersonId(int personId)
        {
            var parameters = new { personId };

            var sql = $"SELECT * FROM Pets WHERE OwnerId = @{nameof(personId)}";

            var pets = await DbConnection.QueryAsync<Pet>(sql, parameters);

            return pets;
        }

        public async Task<IEnumerable<Person>> GetPersonsByCity(string city)
        {
            var parameters = new {city};

            var sql =
                $"SELECT * FROM Persons p INNER JOIN Addresses a ON a.PersonId = p.Id AND a.City = @{nameof(city)}";

            var persons = await DbConnection.QueryAsync<Person>(sql, parameters);

            return persons;
        }
    }
}