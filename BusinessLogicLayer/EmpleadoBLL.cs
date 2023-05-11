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

        public void Actualizar(Empleado entidad)
        {
            throw new NotImplementedException();
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
    }
}
