using System.ComponentModel.DataAnnotations;

namespace SisCit_System.Models
{
    public class Cita
    {

        // Propiedades de la clase Cita
        [Key]
        public int id_cita { get; set; }
        public DateTime fecha_cita { get; set; }
        public TimeSpan hora_cita { get; set; }

        //Llaves foraneas
        public int id_servicio { get; set; }
        public int id_usuario { get; set; }
        public int id_negocio { get; set; }

        //Propiedades de navegación
        public Servicio Servicio { get; set; }
        public Usuario Usuario { get; set; }
        public Negocio Negocio { get; set; }
    }
}