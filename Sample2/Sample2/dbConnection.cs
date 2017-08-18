using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    using System;
    using System.Data.SqlClient;

    public class DBConnection
    {
        private static DBConnection instance;

        private DBConnection() { }

        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnection();
                }
                return instance;
            }
        }

        private string GetConnectionString()
        {
            string username = "sa";
            string password = "root";
            string connetionString = "Data Source=(local);Initial Catalog=Glam;User ID=" + username + ";Password=" + password;
            return connetionString;//Properties.Settings.Default.MyConnectionString;
        }

        public SqlConnection getConn()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
