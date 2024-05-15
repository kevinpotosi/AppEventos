using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos
{
    public class Asistente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public int EventoId { get; set; }
        public Evento? Evento { get; set; }
    }
}
