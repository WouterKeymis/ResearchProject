using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ResearchProject.DAL;
using ResearchProject.DTO;
using ResearchProject.Models;

namespace ResearchProject.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VetsController : ControllerBase
    {
        private readonly IVetenaryRepository _vetRepo;
        private readonly IMapper _mapper;

        public VetsController(IVetenaryRepository vetRepo, IMapper mapper)
        {
            _vetRepo = vetRepo;
            _mapper = mapper;
        }

        [HttpGet("{petId}")]
        [ProducesResponseType(typeof(IEnumerable<Veterinary>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetByPetId(int petId)
        {
            try
            {
                var vet = await _vetRepo.GetVetByPetId((petId));
                if (vet == null) return NotFound();

                return Ok(_mapper.Map<VeterinaryDto>(vet));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
