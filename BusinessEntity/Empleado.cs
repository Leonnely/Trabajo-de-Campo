using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Empleado
    {
        public Usuario usuario;

        public Empleado() 
        {
            Usuario usuario = null;
        }
     
        public int codEMP { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        
        public string Correo { get; set; }
        
        public string DireccionHogar { get; set; }
        
        public string Telefono { get; set; }
        
        public string EstadoEmpleado { get; set; }
        
        public DateTime FechaIngreso { get; set; }
    }
}
