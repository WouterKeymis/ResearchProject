using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchProject.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VetsController : ControllerBase
    {
        [HttpGet("{petId}")]
        public async Task<IActionResult> GetByPetId(int petId)
        {
            return Ok();
        }
    }
}
