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
    public class EmpleadoDAL : IRepository<Empleado>
    {
        SqlConnection oConnection;
        
        public EmpleadoDAL()
        {
            oConnection = new SqlConnection(Connection.GetConnectionString());
        }


        public void Actualizar(Empleado entidad)
        {
             string query = "UPDATE Empleado SET NombreUsuario = @NombreUsuario, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, DireccionHogar = @DireccionHogar, Telefono = @Telefono, EstadoEmpleado = @EstadoEmpleado, FechaIngreso = @FechaIngreso WHERE codEMP = @codEMP";

            oConnection.Open();
            SqlTransaction transaction = oConnection.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(query, oConnection);
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@NombreUsuario", entidad.NombreUsuario);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                cmd.Parameters.AddWithValue("@Correo", entidad.Correo);
                cmd.Parameters.AddWithValue("@DireccionHogar", entidad.DireccionHogar);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@EstadoEmpleado", entidad.EstadoEmpleado);
                cmd.Parameters.AddWithValue("@FechaIngreso", entidad.FechaIngreso);
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
                    empleado.NombreUsuario = (string)reader["NombreUsuario"];
                }

                miLista.Add(empleado);
            }
            oConnection.Close();
            oConnection.Dispose();
            return miLista;
        }
    }
}
