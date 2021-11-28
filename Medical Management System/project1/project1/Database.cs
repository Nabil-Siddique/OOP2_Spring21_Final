using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project1
{
    class Database
    {
        static SqlConnection conn;

        public static SqlConnection ConnectDB()
        {
            String connString = @"Server=HAL9000\SQLEXPRESS;Database=db_dms;User Id= sa;Password=1234asdf;";
                conn = new SqlConnection(connString);
            return conn;
        }
    }
}

// var conn = Database.ConnectDB();

