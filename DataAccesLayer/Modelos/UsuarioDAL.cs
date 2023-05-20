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
    public class UsuarioDAL : IRepository<Usuario>
    {
        SqlConnection oConnection;
        public UsuarioDAL() 
        {
            oConnection = new SqlConnection(Connection.GetConnectionString());
        }

        public void Actualizar(Usuario entidad)
        {
            throw new NotImplementedException();
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

            string query = "SELECT * FROM Usuario WHERE codEMP = @codEMP";
            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query, oConnection);
            cmd.Parameters.AddWithValue("@codEMP", codEMP);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                usuario.NombreUsuario = (string)reader["NombreUsuario"];
                usuario.EstadoCuenta = (string)reader["EstadoCuenta"];
                usuario.codEMP = (int)reader["codEMP"];
                usuario.FechaCreacion = (DateTime)reader["FechaCreacion"];
                usuario.Password = (string)reader["Password"];
            }
            oConnection.Close();
            return usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
