using BusinessEntity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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
             string query = "UPDATE Empleado SET NombreUsuario = @NombreUsuario, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, DireccionHogar = @DireccionHogar, Telefono = @Telefono, EstadoEmpleado = @EstadoEmpleado, FechaIngreso = @FechaIngreso,EsUsuario = @EsUsuario WHERE codEMP = @codEMP";

            oConnection.Open();
            SqlTransaction transaction = oConnection.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(query, oConnection);
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                cmd.Parameters.AddWithValue("@Correo", entidad.Correo);
                cmd.Parameters.AddWithValue("@DireccionHogar", entidad.DireccionHogar);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@EstadoEmpleado", entidad.EstadoEmpleado);
                cmd.Parameters.AddWithValue("@FechaIngreso", entidad.FechaIngreso);
                cmd.Parameters.AddWithValue("@EsUsuario", entidad.EsUsuario);
                cmd.Parameters.AddWithValue("@codEMP", entidad.codEMP);

                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                transaction.Rollback();
                
            }
            finally 
            {
                oConnection.Close(); 
            }

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

        public Empleado ObtenerPorUsuario(string username)
        {
            string query = "SELECT * FROM Empleado WHERE NombreUsuario = @NombreUsuario";

            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query, oConnection);
            cmd.Parameters.AddWithValue("@NombreUsuario", username);
            SqlDataReader reader = cmd.ExecuteReader();

            Empleado emp = new Empleado();
            while (reader.Read())
            {
                DateTime FechaIngreso;

                emp.codEMP = (int)reader["codEMP"];
                emp.Nombre = (string)reader["Nombre"];
                emp.Apellido = (string)reader["Apellido"];
                emp.Correo = (string)reader["Correo"];
                emp.DireccionHogar = (string)reader["DireccionHogar"];
                emp.Telefono = (string)reader["Telefono"];
                emp.EstadoEmpleado = (string)reader["EstadoEmpleado"];
                if (DateTime.TryParse(reader["FechaIngreso"].ToString(), out FechaIngreso))
                {
                    emp.FechaIngreso = FechaIngreso;
                }

                if (reader.IsDBNull(4) == false)
                {
                    //emp.NombreUsuario = (string)reader["NombreUsuario"];
                }
            }
            oConnection.Close();
            return emp;
        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> miLista = new List<Empleado>();
            DateTime FechaIngreso;
            string query = "select * from Empleado";
            SqlCommand command = new SqlCommand(query, oConnection);
            oConnection.Open();
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Empleado empleado = new Empleado();
                empleado.codEMP = (int)reader["codEMP"];
                empleado.Nombre = (string)reader["Nombre"];
                empleado.Apellido = (string)reader["Apellido"];
                empleado.Correo = (string)reader["Correo"];
                empleado.DireccionHogar = (string)reader["DireccionHogar"];
                empleado.Telefono = (string)reader["Telefono"];
                empleado.EstadoEmpleado = (string)reader["EstadoEmpleado"];
                if (DateTime.TryParse(reader["FechaIngreso"].ToString(), out FechaIngreso))
                {
                    empleado.FechaIngreso = FechaIngreso;
                }

                if (reader.IsDBNull(4) == false)
                {
                    //empleado.NombreUsuario = (string)reader["NombreUsuario"];
                }

                miLista.Add(empleado);
            }
            oConnection.Close();
            oConnection.Dispose();
            return miLista;
        }

        public List<Empleado> ObtenerTodosSinUsuarios()
        {
            List<Empleado> miLista = new List<Empleado>();
            DateTime FechaIngreso;

            SqlCommand command = new SqlCommand("ObtenerEmpleadosSinUsuario", oConnection);
            command.CommandType = CommandType.StoredProcedure;
            oConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Empleado empleado = new Empleado();
                empleado.codEMP = (int)reader["IDEmp"];
                empleado.Nombre = (string)reader["Nombre"];
                empleado.Apellido = (string)reader["Apellido"];
                empleado.DNI = (string)reader["DNI"];
                empleado.Correo = (string)reader["Correo"];
                empleado.DireccionHogar = (string)reader["DireccionHogar"];
                empleado.Telefono = (string)reader["Telefono"];
                empleado.EstadoEmpleado = (string)reader["EstadoEmpleado"];
                if (DateTime.TryParse(reader["FechaIngreso"].ToString(), out FechaIngreso))
                {
                    empleado.FechaIngreso = FechaIngreso;
                }
                miLista.Add(empleado);
            }
            oConnection.Close();
            oConnection.Dispose();
            return miLista;
        }

    }
}
