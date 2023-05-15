using BusinessEntity;
using DataAccessLayer.Modelos;
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

        private static Empleado _emp;

        public static SessionManager Connect(string user)
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            if (_session == null)
            {
                _session = new SessionManager();
                _emp = empleadoDAL.ObtenerPorUsuario(user);
                _emp.usuario = usuarioDAL.ObtenerPorId(_emp.codEMP);
            }

            return _session;
        }

        public static void Disconnect()
        {
            if (_session != null)
            {
                _session = null;
                _emp = null;
            }
        }

        public static Empleado getEmpleado()
        {
            return _emp;
        }
    }
}

