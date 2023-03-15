using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AplikacjaWS
{
    internal class DB
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=felichka");

        public void OpenConnetcion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                
            }
           
                
            
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                
            }
            
               
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
