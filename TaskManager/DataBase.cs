using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TaskManager
{
    internal class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-KGHREVN\SQLEXPRESS;Initial Catalog=Accounts; Integrated Security=True");


        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closedConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
