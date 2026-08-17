using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisCit_System.Data;
using SisCit_System.Models;

namespace SisCit_System.Controllers
{
    // Esto define la URL, será algo como: localhost:5000/api/Citas
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly AppDbContext _context; //variable que representa la base de datos (DbContext)

        //Constructor que recibe la base de datos como parámetro y la asigna a la variable _context
        public CitasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Citas (Pide la lista de citas)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetCitas()
        {
            // Va a la base de datos, trae todos las citas y los devuelve
            return await _context.Citas.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Cita>> PostCita(Cita cita)
        {
            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();

            return Ok(cita);
        }
    }
}
