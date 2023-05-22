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
    public class UsuarioDAL : IRepository<Usuario>
    {
        SqlConnection oConnection;
        public UsuarioDAL() 
        {
            oConnection = new SqlConnection(Connection.GetConnectionString());
        }

        public void Actualizar(Usuario entidad)
        {
            string query = "UPDATE Usuarios SET " +
                            "NombreUsuario = @NombreUsuario, " +
                            "Password = @Password, " +
                            "EstadoCuenta = @EstadoCuenta, " +
                            //"UltimoInicio = @UltimoInicio, " +
                            "StateBlock = @StateBlock " +
                            "WHERE IDEmp = @IDEmp";

            // Asigna los parámetros
            SqlCommand cmd = new SqlCommand(query, oConnection);
            cmd.Parameters.AddWithValue("@IDEmp", entidad.codEMP);
            cmd.Parameters.AddWithValue("@NombreUsuario", entidad.NombreUsuario);
            cmd.Parameters.AddWithValue("@Password", entidad.Password);
            cmd.Parameters.AddWithValue("@EstadoCuenta", entidad.EstadoCuenta);
            //cmd.Parameters.AddWithValue("@UltimoInicio", entidad.UltimoInicio);
            cmd.Parameters.AddWithValue("@StateBlock", entidad.StateBlock);
            oConnection.Open();

            // Ejecuta la consulta de actualización
            cmd.ExecuteNonQuery();
            oConnection.Close();
            
        }

        public void Agregar(Usuario oUsuario)
        {
            oConnection.Open();
            SqlTransaction transaction = oConnection.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand("InsertarUsuario", oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Transaction = transaction;

                cmd.Parameters.Add(new SqlParameter("@IDEmp", oUsuario.codEMP));
                cmd.Parameters.Add(new SqlParameter("@NombreUsuario", oUsuario.NombreUsuario));
                cmd.Parameters.Add(new SqlParameter("@Password", oUsuario.Password));
                cmd.Parameters.Add(new SqlParameter("@FechaCreacion", oUsuario.FechaCreacion));
                cmd.Parameters.Add(new SqlParameter("@EstadoCuenta", oUsuario.EstadoCuenta));
                cmd.Parameters.Add(new SqlParameter("@UltimoInicio", oUsuario.UltimoInicio));
                cmd.Parameters.Add(new SqlParameter("@StateBlock", oUsuario.StateBlock));

                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Error al insertar usuario: " + ex.Message);
            }
            finally
            {
                oConnection.Close();
            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorId(int codEMP)
        {
            Usuario usuario = new Usuario();

            string query = "SELECT * FROM Usuarios WHERE IDEmp = @codEMP";
            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query, oConnection);
            cmd.Parameters.AddWithValue("@codEMP", codEMP);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                usuario.codEMP = (int)reader["IDEmp"];
                usuario.NombreUsuario = (string)reader["NombreUsuario"];
                usuario.Password = (string)reader["Password"];
                usuario.FechaCreacion = (DateTime)reader["FechaCreacion"];
                usuario.EstadoCuenta = (string)reader["EstadoCuenta"];
            }
            oConnection.Close();
            return usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuarios";
            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query, oConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                
                usuario.codEMP = (int)reader["IDEmp"];
                usuario.NombreUsuario = (string)reader["NombreUsuario"];
                usuario.Password = (string)reader["Password"];
                usuario.FechaCreacion = (DateTime)reader["FechaCreacion"];
                usuario.EstadoCuenta = (string)reader["EstadoCuenta"];
                usuario.StateBlock = (bool)reader["StateBlock"];
            
                Usuarios.Add(usuario);
            }
            oConnection.Close();
            return Usuarios;
        }

        
    }
}
