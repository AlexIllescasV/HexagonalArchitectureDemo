
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivers.Adapters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HexaArchDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly TestContext _context;

        public PersonaController(TestContext context)
        {
            _context = context;
        }

        // GET  ALL PERSONAS
        // GET: api/personas
        [HttpGet]
        public IActionResult GetAll ()
        {
            PersonaDriverAdapter personaConnect = new PersonaDriverAdapter(_context);
            return Ok(personaConnect.GetPersonaDepartamentoPar());
        }
    }
}
// GET http://localhost:portnumber/api/persona    