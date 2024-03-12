using System;
using System.Collections.Generic;

namespace TelefonoLorena.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            TelefonoCliente = new List<TelefonoCliente>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;

        public virtual IList<TelefonoCliente> TelefonoCliente { get; set; }
    }
}
