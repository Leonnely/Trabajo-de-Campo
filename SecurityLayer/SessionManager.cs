using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayer
{
    public class SessionManager
    {
        //Constructor privado
        private SessionManager()
        {
            //TODO: Agregar en contructor un Usuario
        }
        
        private static SessionManager _session;

        public DateTime fechaInicio { get; set; }

        public static SessionManager getInstance()
        {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.fechaInicio = DateTime.Now;
            }

            return _session;
        }
    }
}

