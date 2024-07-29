
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivers.Adapters;
using HexaArchDemo.Infrastructure.Drivers.Ports;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HexaArchDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaDriverPort _personaDriverPort; 

        public PersonaController(IPersonaDriverPort personaDriverPort)
        {
            _personaDriverPort = personaDriverPort;
        }

        // GET  ALL PERSONAS
        // GET: api/persona
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _personaDriverPort.GetPersonaDepartamentoPar();
            return Ok(result);
        }
    }
}
// GET http://localhost:portnumber/api/persona    