using BusinessEntity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Modelos
{
    public class EmpleadoDAL : IRepository<Empleado>
    {
        SqlConnection oConnection;
        
        public EmpleadoDAL()
        {
            oConnection = new SqlConnection(Connection.GetConnectionString());
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
            List<Empleado> miLista = new List<Empleado>();

            string query = "select * from Empleados";
            SqlCommand command = new SqlCommand(query, oConnection);
            SqlDataReader reader = command.ExecuteReader();

            oConnection.Open();

            while (reader.Read())
            {
                Empleado empleado = new Empleado();
                empleado.codEMP = (int)reader["codEMP"];
                empleado.Nombre = (string)reader["Nombre"];
                empleado.Apellido = (string)reader["Apellido"];
                empleado.Correo = (string)reader["Correo"];
                empleado.DireccionHogar = (string)reader["DireccionHogar"];
                empleado.Telefono = (string)reader["Telefono"];
                empleado.FechaIngreso = (DateTime)reader["FechaIngreso"];

                miLista.Add(empleado);
            }
            oConnection.Close();
            oConnection.Dispose();
            return miLista;
        }
    }
}
