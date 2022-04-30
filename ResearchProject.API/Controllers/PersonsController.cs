using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResearchProject.DAL;
using ResearchProject.Models;

namespace ResearchProject.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        [ProducesResponseType(typeof(IEnumerable<Person>), 200)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var persons = await _personRepository.GetAll();
            return Ok(persons);
        }

        [HttpGet("{personId}")]
        public async Task<IActionResult> GetById(int personId)
        {
            var person = await _personRepository.GetById(personId);
            return Ok(person);
        }

        [HttpGet("Addresses/{personId}")]
        public async Task<IActionResult> GetAddressesByPersonId(int personId)
        {
            var addresses = await _personRepository.GetAddressesByPersonId(personId);

            return Ok(addresses);
        }

        [HttpGet("Pets/{personId}")]
        public async Task<IActionResult> GetPetsByPersonId(int personId)
        {
            var pets = await _personRepository.GetPetsByPersonId(personId);

            return Ok(pets);
        }
    }
}