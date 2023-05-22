using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string EstadoCuenta{ get; set; }
        public DateTime UltimoInicio { get; set; }
        public int codEMP { get; set; }
        public bool StateBlock { get; set; }
    }
}

