﻿using BusinessEntity;
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
            string query = "INSERT INTO Usuario ([NombreUsuario], " +
                "[Password], " +
                "[FechaCreacion], " +
                "[EstadoCuenta], " +
                "[UltimoInicio], " +
                "[codEMP]) VALUES (@NombreUsuario, @Password, @FechaCreacion, @EstadoCuenta, @UltimoInicio, @CodEMP)";


            oConnection.Open();
            SqlTransaction transaction = oConnection.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(query, oConnection);
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@NombreUsuario", oUsuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Password", oUsuario.Password);
                cmd.Parameters.AddWithValue("@FechaCreacion", oUsuario.FechaCreacion);
                cmd.Parameters.AddWithValue("@EstadoCuenta", oUsuario.EstadoCuenta);
                cmd.Parameters.AddWithValue("@UltimoInicio", oUsuario.UltimoInicio);
                cmd.Parameters.AddWithValue("@CodEMP", oUsuario.codEMP);

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
