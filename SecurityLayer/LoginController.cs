using BusinessEntity;
using DataAccessLayer;
using DataAccessLayer.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayer
{
    public class LoginController
    {
        SqlConnection oConnection;

		public LoginController()
		{
			_intentos = 3;
            oConnection = new SqlConnection(Connection.GetConnectionString());

        }

		private int _intentos;
		private int id;

		public int Intentos
		{
			get { return _intentos; }
			set { _intentos = value; }
		}

		public bool Login(string username, string password)
		{
            Credenciales credenciales = new Credenciales();
            if (credenciales.getCredenciales(username, password))
            {
                SessionManager.Connect(credenciales.ID);

                return true;
            }
            return false;			
		}

		public void BlockUsuario(string identificador)
		{
            try
            {
                string sp = "UpdateStateBlock";
                oConnection.Open();
                SqlCommand cmd = new SqlCommand(sp,oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", identificador);
                cmd.ExecuteNonQuery();
                oConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
		}

        public bool isBlocked(string identificador)
        {
            bool isBlocked;

            string query =
                "SELECT CASE WHEN StateBlock = 0 THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS Resultado " +
                "FROM Usuarios " +
                "WHERE NombreUsuario = @NombreUsuario;";

            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query, oConnection);
            cmd.Parameters.AddWithValue("@NombreUsuario", identificador);
            object result = cmd.ExecuteScalar();
            isBlocked = Convert.ToBoolean(result);

            oConnection.Close();

            return isBlocked;
        }
        public void resetIntento() => Intentos = 0;

		public void restarIntento() => Intentos -= 1;

	}
}
