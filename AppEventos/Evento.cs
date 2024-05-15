using System.ComponentModel.DataAnnotations;

namespace AppEventos
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime? Fecha { get; set; }
        public List<Asistente>? Asistentes { get; set;}
    }
}
