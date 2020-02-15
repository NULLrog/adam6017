using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.31.164";
            int port = 3306;
            string database = "adam";
            string username = "root";
            string password = "password";
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}