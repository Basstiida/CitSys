using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisCit_System.Data;
using SisCit_System.Models;

namespace SisCit_System.Controllers
{
    // Esto define la URL, será algo como: localhost:5000/api/Negocios
    [Route("api/[controller]")]
    [ApiController]
    public class NegociosController : ControllerBase
    {
        private readonly AppDbContext _context; //variable que representa la base de datos (DbContext)

        //Constructor que recibe la base de datos como parámetro y la asigna a la variable _context
        public NegociosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Negocios (Pide la lista de negocios)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Negocio>>> GetNegocios()
        {
            // Va a la base de datos, trae todos los negocios y los devuelve
            return await _context.Negocios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Negocio>> PostNegocio(Negocio negocio)
        {
            _context.Negocios.Add(negocio);
            await _context.SaveChangesAsync();

            return Ok(negocio);
        }
    }
}
