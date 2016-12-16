using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizaYA_00.Data
{
    class ConnectionData
    {

        private SqlConnection connection;
        private string dataSource = "Data Source=DESKTOP-0J8ESI8\\SQLEXPRESS;Initial Catalog=xregister;Integrated Security=true;";
        private SqlDataReader reader;

        public ConnectionData()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = dataSource;
        }

        public bool pushQuery(string query)
        {
            this.connection.Open();
            SqlCommand cmd = new SqlCommand(query, this.connection);

            try
            {
                int result = cmd.ExecuteNonQuery();
                this.connection.Close();
                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
