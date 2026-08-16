using System.ComponentModel.DataAnnotations;

namespace SisCit_System.Models
{
    public class Servicio
    {
        [Key]
        public int id_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public int duracion_servicio { get; set; }
        public string descripcion_servicio { get; set; }
    }
}
