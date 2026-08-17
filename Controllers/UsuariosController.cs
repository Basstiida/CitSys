using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisCit_System.Data;
using SisCit_System.Models;

namespace SisCit_System.Controllers
{
    // Esto define la URL, será algo como: localhost:5000/api/Servicios
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context; //variable que representa la base de datos (DbContext)

        //Constructor que recibe la base de datos como parámetro y la asigna a la variable _context
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios (Pide la lista de usuarios)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            // Va a la base de datos, trae todos los usuarios y los devuelve
            return await _context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(usuario);
        }
    }
}