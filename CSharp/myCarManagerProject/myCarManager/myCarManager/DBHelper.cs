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

        public static void selectQuery(int parkingSpot = -1)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (parkingSpot < 0)
                    cmd.CommandText = "Select * from CarManager";
                else
                    cmd.CommandText = "Select * from CarManager where ParkingSpot = " + parkingSpot;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "CarManager");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "select 오류");
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void insertQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "insert into carManager (parkingSpot) values (@p1)";

                SqlCommand cmd = new SqlCommand();
                
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message + "insert 오류");
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void deleteQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlCommand = "delete from carManager where parkingSpot = @p1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlCommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void updateQuery(int parkingSpot, string carNumber, 
                                       string driverName, string phoneNumber,
                                       bool isRemove=false)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlCommand;
                if(isRemove)
                {
                    sqlCommand = "update carmanager set carnumber='', drivername='', phonenumber=''," +
                                 " parkingtime=null where parkingspot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSpot);
                }
                else
                {
                    sqlCommand = "update carmanager set carnumber=@p1, drivername=@p2, phonenumber=@p3," +
                        "parkingtime=@p4 where parkingspot=@p5";
                    cmd.Parameters.AddWithValue("@p1", carNumber);
                    cmd.Parameters.AddWithValue("@p2", driverName);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpot);
                }
                cmd.CommandText = sqlCommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
