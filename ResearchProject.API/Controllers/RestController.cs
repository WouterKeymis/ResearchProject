using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResearchProject.DAL.Interfaces;
using ResearchProject.Models;

namespace ResearchProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IAddressRepository _addressRepository;

        public RestController(IPersonRepository personRepository, IAddressRepository addressRepository)
        {
            _personRepository = personRepository;
            _addressRepository = addressRepository;
        }

        [HttpGet("Person")]
        public IActionResult Get()
        {
            var persons = _personRepository.GetAll();

            return Ok(persons);
        }

        [HttpGet("Person/id")]
        public IActionResult GetById(int id)
        {
            var person = _personRepository.GetById(id);

            return Ok(person);
        }

        [HttpGet("Person/id/addresses")]
        public IActionResult GetAddresses(int id)
        {
            var addressess = _addressRepository.GetByPersonId(id);

            return Ok(addressess);
        }

        [HttpGet("Person/id/interests")]
        public IActionResult GetInterests(int id)
        {
            var interests = "interests";

            return Ok(interests);
        }

        [HttpGet("Person/id/pets")]
        public IActionResult GetPets(int id)
        {
            var pets = "pets pets pets";

            return Ok(pets);
        }




    }
}
