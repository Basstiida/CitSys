using System.ComponentModel.DataAnnotations;

namespace SisCit_System.Models
{
    public class Negocio
    {
        [Key]
        public int id_negocio { get; set; }
        public string nombre_negocio { get; set; }
        public string direccion_negocio { get; set; }
        public string telefono_negocio { get; set; }
        public string correo_negocio { get; set; }
    }
}