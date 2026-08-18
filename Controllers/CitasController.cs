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

        [HttpPut("{id}")]
        public IActionResult ActualizarCita(int id, [FromBody] Cita citaActualizada)
        {
            // 1. Validamos que los IDs coincidan
            if (id != citaActualizada.id_cita)
            {
                return BadRequest("El ID de la URL no coincide con la información de la cita.");
            }

            //2. Buscamos la cita en SQL Server
            var citaExistente = _context.Citas.Find(id);
            if (citaExistente == null)
            {
            return NotFound("No se encontró la cita que intentas actualizar.");
            }

            //3. Actualizamos los datos
            citaExistente.fecha_cita = citaActualizada.fecha_cita;
            citaExistente.hora_cita = citaActualizada.hora_cita;
            citaExistente.id_servicio = citaActualizada.id_servicio;
            citaExistente.id_usuario = citaActualizada.id_usuario;
            citaExistente.id_negocio = citaActualizada.id_negocio;

            // 4. Guardamos los cambios
            _context.SaveChanges();

            return Ok("Cita actualizada correctamente.");
        }
    }
}
