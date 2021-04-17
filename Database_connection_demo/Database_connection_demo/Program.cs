using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_connection_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = @"Server=DESKTOP-LSE8ACET\SQL_SERVER;Database=OOP2_H_SP21;User Id=ka;Password=PONG;";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

        }
    }
}
