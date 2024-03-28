using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginandCreateacountCsharp
{
     class Connection
    {
        private static string ConnectionString = @"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=AccountLogin;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
