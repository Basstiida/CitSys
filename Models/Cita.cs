using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("id_servicio")]
        public Servicio? Servicio { get; set; }
        [ForeignKey("id_usuario")]
        public Usuario? Usuario { get; set; }
        [ForeignKey("id_negocio")]
        public Negocio? Negocio { get; set; }
    }
}