using System;
using System.Collections.Generic;

namespace prueba.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
