using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayer
{
    public class Credenciales
    {
        SqlConnection oConnection;
        CryptoManager cryptoManager = new CryptoManager();

        public string NombreUsuario { get; set; }
        public string passwordHash { get; set; }
        public int ID { get; set; }

        public Credenciales()
        {
            oConnection = new SqlConnection(Connection.GetConnectionString());
        }

        public bool getCredenciales(string identificador,string PasswordInput)
        {
            string query = "SELECT NombreUsuario,Password,IDEmp FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

            oConnection.Open();
            SqlCommand cmd = new SqlCommand(query,oConnection);
            cmd.Parameters.AddWithValue("@NombreUsuario", identificador);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                passwordHash = Reader[1].ToString();
                ID = (int)Reader[2];
            }
            oConnection.Close();



            return comparePassword(cryptoManager.HashPassword(PasswordInput), passwordHash);
        }

        

        public bool comparePassword(string passwordInput,string passwordBD)
        {
            bool coinciden = string.Equals(passwordBD, passwordInput);
            return coinciden;
        }

        

    }
}
