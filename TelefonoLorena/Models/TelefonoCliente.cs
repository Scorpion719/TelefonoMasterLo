using System;
using System.Collections.Generic;

namespace TelefonoLorena.Models
{
    public partial class TelefonoCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NumeroTelefono { get; set; } = null!;
        public string Compañia { get; set; } = null!;

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
    }
}
