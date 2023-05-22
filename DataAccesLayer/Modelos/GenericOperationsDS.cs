using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Modelos
{
    public class GenericOperationsDS
    {
        public GenericOperationsDS() { }

        SqlConnection oConnection = new SqlConnection(Connection.GetConnectionString());

        public DataSet ObtenerTodosByDataSet(string tabla)
        {
            string query = $"SELECT * FROM {tabla}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, oConnection);
            DataSet dataSet = new DataSet();

            oConnection.Open();
            adapter.Fill(dataSet, $"{tabla}");
            oConnection.Close();

            return dataSet;
        }

        public void GrabarCambiosByDataSet(DataSet dset,string tabla)
        {
            SqlDataAdapter DA = new SqlDataAdapter(($"SELECT * FROM {tabla}"), oConnection);

            SqlCommandBuilder CB = new SqlCommandBuilder(DA);
            DA.UpdateCommand = CB.GetUpdateCommand();
            DA.DeleteCommand = CB.GetDeleteCommand();
            DA.InsertCommand = CB.GetInsertCommand();
            DA.ContinueUpdateOnError = true;
            DA.Fill(dset);
            DA.Update(dset.Tables[0]);
        }
    }
}
