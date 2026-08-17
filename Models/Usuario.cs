using System.ComponentModel.DataAnnotations;

namespace SisCit_System.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidoPat_usuario { get; set; }
        public string apellidoMat_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string contrasena_usuario { get; set; }
        public string rol_usuario { get; set; }
    }
}