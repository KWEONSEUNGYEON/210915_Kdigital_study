using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCarManager
{
    public class DBHelper
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "initial Catalog={1};" +
                "integrated Security={2};" +
                "Timeout=3",
                "local", "MyCarManagerDB", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }
    }
}
