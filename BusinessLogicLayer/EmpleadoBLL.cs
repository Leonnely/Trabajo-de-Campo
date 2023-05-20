using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer.Modelos;
using Interfaces;

namespace BusinessLogicLayer
{
    public class EmpleadoBLL : IRepository<Empleado>
    {
        EmpleadoDAL GestorEmpleados;

        public EmpleadoBLL()
        {
            GestorEmpleados = new EmpleadoDAL();
        }


        public string CrearNombreUsuario(Empleado emp)
        {
            string NombreUsuario = emp.Nombre.Substring(0, 2) + emp.Apellido.Substring(0, 2) + emp.Telefono.Substring(emp.Telefono.Length - 2);

            return NombreUsuario;
        }

        public void Actualizar(Empleado entidad)
        {
            GestorEmpleados.Actualizar(entidad);
        }

        public void Agregar(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Empleado ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> ObtenerTodos()
        {
            return GestorEmpleados.ObtenerTodos();
        }

        public object ObtenerTodosSinUsuarios()
        {
            return GestorEmpleados.ObtenerTodosSinUsuarios();
        }
    }
}
