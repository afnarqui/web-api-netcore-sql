using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models.Request
{
    public class PersonaRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
