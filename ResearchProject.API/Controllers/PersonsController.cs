using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ResearchProject.DAL;
using ResearchProject.DTO;
using ResearchProject.Models;

namespace ResearchProject.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonsController(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Person>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var persons = await _personRepository.GetAll();
                if (!persons.Any()) return NotFound();

                return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpGet("{personId}")]
        [ProducesResponseType(typeof(Person), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetById(int personId)
        {
            try
            {
                var person = await _personRepository.GetById(personId);
                if (person == null) return NotFound();

                return Ok(_mapper.Map<PersonDto>(person));
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [ProducesResponseType(typeof(IEnumerable<Address>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("Addresses/{personId}")]
        public async Task<IActionResult> GetAddressesByPersonId(int personId)
        {
            try
            {
                var addresses = await _personRepository.GetAddressesByPersonId(personId);
                if (!addresses.Any()) return NotFound();

                return Ok(_mapper.Map<IEnumerable<AddressDto>>(addresses));
            }
            catch
            {
                return BadRequest("Internal server error");
            }

        }

        [ProducesResponseType(typeof(IEnumerable<Pet>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("Pets/{personId}")]
        public async Task<IActionResult> GetPetsByPersonId(int personId)
        {
            try
            {
                var pets = await _personRepository.GetPetsByPersonId(personId);
                if (!pets.Any()) return NotFound();

                return Ok(_mapper.Map<IEnumerable<Pet>>(pets));
            }
            catch
            {
                return BadRequest("Internel server error");
            }
        }

        //Possible endpoint for displaying only people from a certain city
        [HttpGet("Filters/{city}")]
        public async Task<IActionResult> GetByCity(string city)
        {
            try
            {
                var persons = await _personRepository.GetPersonsByCity(city);
                if (!persons.Any()) return NotFound();

                return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

    }
}