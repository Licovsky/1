using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _2
{
    class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server = Doomer\LOCALDB#4A341AEB; Initial Catalog= master; Integrated Security = true");
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {

                sqlConnection.Open();


            }
        }
        public void clocedConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {

                sqlConnection.Close();


            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
